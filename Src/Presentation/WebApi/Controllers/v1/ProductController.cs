﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Application.Services.Products.Queries.GetProduct;
using Application.Services.Products.Queries.GetProducts;

using Application.Services.Products.Commands.UpdateProduct;

using Domain.Entities;

using Logging.Interfaces;

namespace WebApi.Controllers.v1 {

	/// <summary>
	/// Product endpoint v1
	/// </summary>
	/// <seealso cref="BaseController{Product}" />
	[ApiVersion("1")]
	public class ProductController : BaseController<Product> {

		public ProductController(IRequestLogger<Product> logger) : base(logger) { }

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

			Logger.LogRequest(AccessorIp, $"GetById - {result.ProductName} - {DurationMs} ms", 1, DurationMs);

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

			Logger.LogRequest(AccessorIp, $"GetAvailable - {DurationMs} ms", 1, DurationMs);

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

			Logger.LogRequest(AccessorIp, $"Update - {result.ProductUpdated} - {DurationMs} ms", 1, DurationMs);

			if (result.ProductUpdated) {
				return Ok(result);
			}

			return NotFound(result);
		}
	}
}
