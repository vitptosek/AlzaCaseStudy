using System;
using System.Collections.Generic;

using FluentValidation.Results;

using Application.Extensions;

namespace Application.Exceptions {

	public class RequestValidationException : Exception {
		public RequestValidationException(List<ValidationFailure> validationFailures) : base("Request validation failed") {
			foreach (var failure in validationFailures.DistinctFirstBy(failure => failure.PropertyName)) {
				Console.WriteLine($"{failure.PropertyName} - {failure.ErrorMessage}");
			}
		}
	}
}
