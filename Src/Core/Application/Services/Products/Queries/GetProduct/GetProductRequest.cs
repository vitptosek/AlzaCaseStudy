﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MediatR;
using AutoMapper;

using Application.Interfaces;

namespace Application.Services.Products.Queries.GetProduct {

	public class GetProductRequest : IRequest<GetProductResponse> {
		public Guid ProductId { internal get; set; }

		public class Handler : IRequestHandler<GetProductRequest, GetProductResponse> {
			private readonly IMapper _mapper;
			private readonly IDbContext _dbContext;

			public Handler(IMapper mapper, IDbContext dbContext) {
				_mapper = mapper;
				_dbContext = dbContext;
			}

			public async Task<GetProductResponse> Handle(GetProductRequest request, CancellationToken cancellationToken) {
				var entity = await _dbContext.Products.Include(product => product.Stores)
														.ThenInclude(storeProduct => storeProduct.Store)
														.FirstOrDefaultAsync(product => product.Id == request.ProductId, cancellationToken);

				return _mapper.Map<GetProductResponse>(entity);
			}
		}
	}
}
