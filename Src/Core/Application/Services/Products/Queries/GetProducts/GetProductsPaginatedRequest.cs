using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using MediatR;
using X.PagedList;
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Application.Interfaces;

namespace Application.Services.Products.Queries.GetProducts {

	/// <summary>
	/// Handles a request for getting all available products paginated
	/// </summary>
	/// <returns>
	/// Prepared query for paginated products (not-deleted) being in at least one store (not-deleted) of at least one count, otherwise empty list
	/// </returns>
	public class GetProductsPaginatedRequest : IRequest<IEnumerable<GetProductsResponse>> {
		public uint PageNumber { internal get; set; }
		public uint PageSize { internal get; set; } = 10;

		public class Handler : IRequestHandler<GetProductsPaginatedRequest, IEnumerable<GetProductsResponse>> {
			private readonly IMapper _mapper;
			private readonly IDbContext _dbContext;

			public Handler(IMapper mapper, IDbContext dbContext) {
				_mapper = mapper;
				_dbContext = dbContext;
			}

			/// <summary>
			/// Handles a request for products paginated on a server-side
			/// </summary>
			/// <param name="request">The request</param>
			/// <param name="cancellationToken">Cancellation token</param>
			/// <returns>
			/// Response from the request - paginated products
			/// </returns>
			public async Task<IEnumerable<GetProductsResponse>> Handle(GetProductsPaginatedRequest request, CancellationToken cancellationToken) {
				var pagedEntities = await _dbContext.Products.Include(product => product.Stores)
																.ThenInclude(storeProduct => storeProduct.Store)
																.Where(product => product.Stores.Any())
																.OrderBy(product => product.Id)
																.ProjectTo<GetProductsResponse>(_mapper.ConfigurationProvider)
																.ToPagedListAsync((int)request.PageNumber, (int)request.PageSize, cancellationToken);

				return await pagedEntities.ToListAsync(cancellationToken);
			}
		}
	}
}
