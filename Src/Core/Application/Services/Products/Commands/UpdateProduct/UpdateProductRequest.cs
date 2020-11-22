﻿using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MediatR;
using AutoMapper;

using Application.Interfaces;

namespace Application.Services.Products.Commands.UpdateProduct {

	public class UpdateProductRequest : IRequest<UpdateProductResponse> {
		public Guid ProductId { internal get; set; }
		public string Description { internal get; set; }

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

				entity.Description = request.Description;

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
