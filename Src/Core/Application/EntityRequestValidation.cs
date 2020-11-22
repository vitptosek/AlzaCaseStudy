using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using MediatR;
using FluentValidation;

namespace Application {
	public class EntityRequestValidation<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse> {
		private readonly IEnumerable<IValidator<TRequest>> _validators;

		public EntityRequestValidation(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;

		public Task<TResponse> Handle(TRequest requestToValidate, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> task) {
			var validationContext = new ValidationContext<TRequest>(requestToValidate);

			var validationFailures = _validators.Select(request => request.Validate(validationContext))
												.SelectMany(validationResult => validationResult.Errors)
												.Where(validationFailure => validationFailure != null)
												.ToList();

			if (validationFailures.Count != 0) {
				throw new Exceptions.RequestValidationException(validationFailures);
			}

			return task();
		}
	}
}