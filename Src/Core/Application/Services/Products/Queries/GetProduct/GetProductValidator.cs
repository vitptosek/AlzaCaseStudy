using FluentValidation;

namespace Application.Services.Products.Queries.GetProduct {

	public class GetProductValidator : AbstractValidator<GetProductRequest> {

		public GetProductValidator() {
			RuleFor(product => product.ProductId).NotNull().WithMessage("Product identifier must be provided");
			RuleFor(product => product.ProductId).NotEmpty().WithMessage("Product identifier cannot be empty or default GUID");
		}
	}
}
