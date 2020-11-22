using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Application.Services.Products.Queries.GetProducts;

using Domain.Entities;

using Logging.Interfaces;

namespace WebApi.Controllers.v2 {

	/// <summary>
	/// Product endpoint v2
	/// </summary>
	/// <seealso cref="BaseController{Product}" />
	[ApiVersion("2")]
	public class ProductController : BaseController<Product> {
		public ProductController(IRequestLogger<Product> logger) : base(logger) { }

		/// <summary>
		/// Gets available products paginated.
		/// </summary>
		/// <param name="pageNumber">The page number.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns>Products as per desired paging if available, otherwise none</returns>
		[HttpGet]
		[MapToApiVersion("2")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<GetProductsResponse>>> GetAvailable(uint pageNumber, uint pageSize = 10) {
			_stopWatch.Restart();
			var results = await ServiceRequest.Send(new GetProductsPaginatedRequest { PageNumber = pageNumber, PageSize = pageSize });
			_stopWatch.Stop();

			Logger.LogRequest(AccessorIp, $"GetAvailablePaginated - {DurationMs} ms", 1, DurationMs);

			if (results.Any()) {
				return Ok(results);
			}

			return NotFound();
		}
	}
}
