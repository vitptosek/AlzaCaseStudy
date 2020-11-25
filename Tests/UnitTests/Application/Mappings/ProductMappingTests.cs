using System;

using Xunit;
using Shouldly;
using AutoMapper;

using Domain.Entities;

using Application;
using Application.Entities.Dto;
using Application.Services.Products.Queries.GetProduct;

namespace UnitTests.Application.Mappings {

	public class ProductMappingTests {
		private readonly IMapper _mapper;
		private readonly IConfigurationProvider _configuration;

		public ProductMappingTests() {
			_configuration = new MapperConfiguration(cfg => {
				cfg.AddProfile<EntityRequestMapping>();
			});

			_mapper = _configuration.CreateMapper();
		}

		[Fact]
		public void Mapping_Configuration_Should_Be_Valid_Test() => _configuration.AssertConfigurationIsValid(); //to make sure we have covered all mappings

		[Fact]
		public void Should_Map_Domain_Product_Entity_To_Application_DTO_Test() {
			var entity = new Product("TV", 10500.50m, new Uri("http://www.uriTv/")) { Id = new Guid("EA0B6D19-A9A1-42CF-8E33-2514FE05F9C6") };

			var entityDto = _mapper.Map<ProductDto>(entity);
			var entityResponse = _mapper.Map<GetProductResponse>(entity);

			entityDto.ShouldNotBeNull();
			entityDto.ShouldBeOfType<ProductDto>();

			entityResponse.ShouldNotBeNull();
			entityResponse.ShouldBeOfType<GetProductResponse>();

			entity.Description.ShouldBeEquivalentTo(entityDto.ProductDescription);
			entity.Description.ShouldBeEquivalentTo(entityResponse.ProductDescription);
		}
	}
}
