using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Application.Services.Products.Queries.GetProducts;

namespace WebApi.Controllers.v2 {

	/// <summary>
	/// Product endpoint v2
	/// </summary>
	/// <seealso cref="BaseController" />
	[ApiVersion("2")]
	public class ProductController : BaseController {
		private readonly Stopwatch _stopWatch;

		public ProductController() => _stopWatch = new Stopwatch();

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

			Console.WriteLine($"GetAvailablePaginated - {_stopWatch.ElapsedMilliseconds} ms"); //TODO: use logger instead

			if (results.Any()) {
				return Ok(results);
			}

			return NotFound();
		}
	}
}
