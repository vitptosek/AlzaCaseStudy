using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using AutoMapper;

using Application.Interfaces;

namespace Application.Services.Products.Commands.UpdateProduct {

	/// <summary>
	/// Handles a request for updating one product by ID for its description (based on Domain)
	/// </summary>
	/// <returns>
	/// Result of product update state (not found/up to date/updated) and updated product in case of success
	/// </returns>
	public class UpdateProductRequest : IRequest<UpdateProductResponse> {
		public Guid ProductId { internal get; set; }
		public string Description { internal get; set; }

		//Note: for partial update we could e.g use (special input/existing) DTO with all editable properties
		//Then in case of only one specific being meant to be updated we could make sure nothing else gets updated as well

		public class Handler : IRequestHandler<UpdateProductRequest, UpdateProductResponse> {
			private readonly IMapper _mapper;
			private readonly IDbContext _dbContext;

			public Handler(IMapper mapper, IDbContext dbContext) {
				_mapper = mapper;
				_dbContext = dbContext;
			}

			public async Task<UpdateProductResponse> Handle(UpdateProductRequest request, CancellationToken cancellationToken) {
				var response = new UpdateProductResponse(false) { ProductUpdateMessage = "Product not found" };

				//Note: this could (and maybe should) be in some internal common service - get from cache or add to it...
				var entity = await _dbContext.Products.FindAsync(request.ProductId);

				//Note: some comments describing how things work could be added but I better believe in code clarity that never gets outdated
				if (entity is null) {
					return response;
				}

				if (entity.Description == request.Description) {
					response.ProductUpdateMessage = "Product already up to date";
					return response;
				}

				entity.UpdateDescription(request.Description);

				try {
					response = _mapper.Map<UpdateProductResponse>(entity);

					_dbContext.Products.Update(entity);
					await _dbContext.SaveChangesAsync(cancellationToken);
				}
				catch (Exception e) {
					response.ProductUpdated = false;
					response.ProductUpdateMessage = e.Message;
				}

				//Note: ...and then we could update the cache (upsert)
				//Note: also MediatR has Publish method Sending INotifications if preferred

				return response;
			}
		}
	}
}
