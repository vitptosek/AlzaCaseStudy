using FluentValidation;

namespace Application.Services.Products.Commands.UpdateProduct {

	public class UpdateProductValidator : AbstractValidator<UpdateProductRequest> {

		public UpdateProductValidator() {
			RuleFor(product => product.ProductId).NotNull().WithMessage("Product identifier must be provided");
			RuleFor(product => product.ProductId).NotEmpty().WithMessage("Product identifier cannot be empty or default GUID");

			RuleFor(product => product.Description).MaximumLength(150).WithMessage("Product description must be of maximum 150 characters");

			//TODO: in case of create/update containing required price - it would be nice to check for negative values (as there is no such a thing as unasigned decimal) etc.
		}
	}
}
