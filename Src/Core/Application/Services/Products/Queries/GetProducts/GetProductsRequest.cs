using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Application.Interfaces;

namespace Application.Services.Products.Queries.GetProducts {

	/// <summary>
	/// Handles a request for getting all available products
	/// </summary>
	/// <returns>
	/// Products (not-deleted) being in at least one store (not-deleted) of at least one count, otherwise empty list
	/// </returns>
	public class GetProductsRequest : IRequest<IEnumerable<GetProductsResponse>> {

		public class Handler : IRequestHandler<GetProductsRequest, IEnumerable<GetProductsResponse>> {
			private readonly IMapper _mapper;
			private readonly IDbContext _dbContext;

			public Handler(IMapper mapper, IDbContext dbContext) {
				_mapper = mapper;
				_dbContext = dbContext;
			}

			public async Task<IEnumerable<GetProductsResponse>> Handle(GetProductsRequest request, CancellationToken cancellationToken) {
				var entities = await _dbContext.Products.Include(product => product.Stores)
														.ThenInclude(storeProduct => storeProduct.Store)
														.Where(product => product.Stores.Any())
														.ProjectTo<GetProductsResponse>(_mapper.ConfigurationProvider)
														.ToListAsync(cancellationToken);

				return entities;
			}
		}
	}
}
