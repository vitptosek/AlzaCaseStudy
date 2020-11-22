using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

using Application.Services.Products.Commands.UpdateProduct;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Application.Services.Products.Queries.GetProduct;
using Application.Services.Products.Queries.GetProducts;

namespace WebApi.Controllers.v1 {

	/// <summary>
	/// Product endpoint v1
	/// </summary>
	/// <seealso cref="BaseController" />
	[ApiVersion("1")]
	public class ProductController : BaseController {
		private readonly Stopwatch _stopWatch;

		public ProductController() => _stopWatch = new Stopwatch();

		/// <summary>
		/// Gets the product by identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>Product if found, otherwise none</returns>
		[HttpGet]
		[MapToApiVersion("1")]
		[MapToApiVersion("2")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<GetProductResponse>> GetById(Guid id) {
			_stopWatch.Restart();
			var result = await ServiceRequest.Send(new GetProductRequest { ProductId = id });
			_stopWatch.Stop();

			if (result is null) {
				return NotFound();
			}

			Console.WriteLine($"GetById - {result.ProductName} - {_stopWatch.ElapsedMilliseconds} ms"); //TODO: use logger instead

			return Ok(result);
		}

		/// <summary>
		/// Gets available products.
		/// </summary>
		/// <returns>Products if available, otherwise none</returns>
		[HttpGet]
		[MapToApiVersion("1")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<GetProductsResponse>>> GetAvailable() {
			_stopWatch.Restart();
			var results = await ServiceRequest.Send(new GetProductsRequest());
			_stopWatch.Stop();

			Console.WriteLine($"GetAvailable - {_stopWatch.ElapsedMilliseconds} ms"); //TODO: use logger instead

			if (results.Any()) {
				return Ok(results);
			}

			return NotFound();
		}

		/// <summary>
		/// Updates the specified product by identifier.
		/// </summary>
		/// <param name="productId">The product identifier.</param>
		/// <param name="description">The description to be updated.</param>
		/// <returns>Updated product if success along with status, otherwise status only</returns>
		[HttpPut]
		[MapToApiVersion("1")]
		[MapToApiVersion("2")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<UpdateProductResponse>> Update(Guid productId, string description) {
			_stopWatch.Restart();
			var result = await ServiceRequest.Send(new UpdateProductRequest { ProductId = productId, Description = description });
			_stopWatch.Stop();

			Console.WriteLine($"Update - {result.ProductUpdated} - {_stopWatch.ElapsedMilliseconds} ms"); //TODO: use logger instead

			if (result.ProductUpdated) {
				return Ok(result);
			}

			return NotFound(result);
		}
	}
}
