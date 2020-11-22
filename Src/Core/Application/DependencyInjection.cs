using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

using MediatR;
using AutoMapper;
using FluentValidation;

namespace Application {

	public static class DependencyInjection {

		public static IServiceCollection AddApplicationServices(this IServiceCollection services) {
			services.AddAutoMapper(typeof(EntityRequestMapping));

			services.AddMediatR(Assembly.GetExecutingAssembly());
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(EntityRequestLogger<,>));
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(EntityRequestValidation<,>));

			return services;
		}
	}
}
