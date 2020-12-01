using System;
using System.Collections.Generic;

using FluentValidation.Results;

using Application.Extensions;

namespace Application.Exceptions {

	public class RequestValidationException : Exception {
		public RequestValidationException(List<ValidationFailure> validationFailures) : base("Request validation failed") {
			var messages = new List<string>();

			validationFailures.DistinctFirstBy(failure => failure.PropertyName)
								.ForEach(failure => messages.Add($"{failure.PropertyName} - {failure.ErrorMessage}"));

			throw new Exception(String.Join(Environment.NewLine, messages));
		}
	}
}
