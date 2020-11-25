using FluentValidation;

namespace Application.Services.Products.Commands.UpdateProduct {

	public class UpdateProductValidator : AbstractValidator<UpdateProductRequest> {

		public UpdateProductValidator() {
			RuleFor(product => product.ProductId).NotNull().WithMessage("Product identifier must be provided");
			RuleFor(product => product.ProductId).NotEmpty().WithMessage("Product identifier cannot be empty or default GUID");

			RuleFor(product => product.Description).MaximumLength(150).WithMessage("Product description must be of maximum 150 characters");

			//Note: we do not support update of required Price attribute but if so, create/update
			//		should validate against negative values (as there is no such a thing as unasigned decimal), i.e RuleFor...GreaterThan(0) etc
		}
	}
}
