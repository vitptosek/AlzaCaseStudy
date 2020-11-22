using AutoMapper;

using Domain.Entities;
using Application.Entities.Dto;

namespace Application {

	public class EntityRequestMapping : Profile {
		public EntityRequestMapping() {
			#region Product

			CreateMap<Product, ProductDto>()
				.ForMember(dto => dto.ProductName, options => options.MapFrom(product => product.Name))
				.ForMember(dto => dto.ProductPrice, options => options.MapFrom(product => product.Price))
				.ForMember(dto => dto.ProductImgUri, options => options.MapFrom(product => product.ImgUri))
				.ForMember(dto => dto.ProductDescription, options => options.MapFrom(product => product.Description));

			CreateMap<Product, ProductIncludesDto>().IncludeBase<Product, ProductDto>()
				.ForMember(dto => dto.ProductStores, options => options.MapFrom(product => product.Stores));

			#endregion
		}
	}
}
