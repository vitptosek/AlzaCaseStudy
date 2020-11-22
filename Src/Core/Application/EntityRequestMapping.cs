using AutoMapper;

using Domain.Entities;
using Domain.Entities.Relations;

using Application.Entities.Dto;

using Application.Services.Products.Queries.GetProduct;
using Application.Services.Products.Queries.GetProducts;

using Application.Services.Products.Commands.UpdateProduct;

namespace Application {

	public class EntityRequestMapping : Profile {
		public EntityRequestMapping() {
			#region Product

			#region Responses

			CreateMap<Product, GetProductResponse>().IncludeBase<Product, ProductDto>();
			CreateMap<Product, GetProductsResponse>().IncludeBase<Product, ProductDto>();

			CreateMap<Product, UpdateProductResponse>().IncludeBase<Product, ProductDto>();

			#endregion

			CreateMap<Product, ProductDto>().IncludeBase<Product, ProductIncludesDto>()
				.ForMember(dto => dto.ProductName, options => options.MapFrom(product => product.Name))
				.ForMember(dto => dto.ProductPrice, options => options.MapFrom(product => product.Price))
				.ForMember(dto => dto.ProductImgUri, options => options.MapFrom(product => product.ImgUri))
				.ForMember(dto => dto.ProductDescription, options => options.MapFrom(product => product.Description));


			CreateMap<Product, ProductIncludesDto>()
				.ForMember(dto => dto.ProductStores, options => options.MapFrom(product => product.Stores));

			#endregion

			#region StoreProduct

			CreateMap<StoreProduct, StoreDto>()
				.ForMember(dto => dto.StoreCity, options => options.MapFrom(storeProduct => storeProduct.Store.City))
				.ForMember(dto => dto.StoreName, options => options.MapFrom(storeProduct => storeProduct.Store.Name));

			#endregion
		}
	}
}
