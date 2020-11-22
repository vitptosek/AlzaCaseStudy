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
		//TODO: for partial update we could e.g use (input/existing) DTO with all editable properties and in case of only one specific we could make sure nothing else gets updated

		public class Handler : IRequestHandler<UpdateProductRequest, UpdateProductResponse> {
			private readonly IMapper _mapper;
			private readonly IDbContext _dbContext;

			public Handler(IMapper mapper, IDbContext dbContext) {
				_mapper = mapper;
				_dbContext = dbContext;
			}

			public async Task<UpdateProductResponse> Handle(UpdateProductRequest request, CancellationToken cancellationToken) {
				var response = new UpdateProductResponse(false) { ProductUpdateMessage = "Product not found" };

				var entity = await _dbContext.Products.FindAsync(request.ProductId);

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

				return response;
			}
		}
	}
}
