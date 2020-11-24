using Application.Entities.Dto;

namespace Application.Services.Products.Commands.UpdateProduct {

	public class UpdateProductResponse : ProductDto { //Note: response like this could rather inherit from some DTO with no navigation properties meant for includes
		public bool ProductUpdated { get; internal set; } = true;
		public string ProductUpdateMessage { get; internal set; } = "Product updated";

		internal UpdateProductResponse() { }
		internal UpdateProductResponse(bool updated) => ProductUpdated = updated;

	}
}
