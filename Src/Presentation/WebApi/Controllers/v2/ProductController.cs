﻿using System;
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
		/// Gets available products paginated by page number and size.
		/// </summary>
		/// <param name="pageNumber">The page number.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns>Products as per desired paging if available, otherwise none</returns>
		[HttpGet("{pageNumber}/{pageSize?}")]
		[MapToApiVersion("2")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<IEnumerable<GetProductsResponse>>> Get(uint pageNumber, uint pageSize = 10) {
			try {
				_stopWatch.Restart();
				var results = await ServiceRequest.Send(new GetProductsPaginatedRequest { PageNumber = pageNumber, PageSize = pageSize, PageOrderKey = product => product.Name });
				_stopWatch.Stop();

				Logger.LogRequest(AccessorIp, $"GetAvailablePaginated - {DurationMs} ms", 1, DurationMs);

				if (results.Any()) {
					return Ok(results);
				}

				return NotFound();
			}
			catch (Exception e) {
				Logger.LogRequest(AccessorIp, $"GetAvailablePaginated - {e.Message}", 1, DurationMs);

				return BadRequest(e.Message);
			}
		}
	}
}
