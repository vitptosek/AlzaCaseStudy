using System;
using System.Diagnostics;

using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace Application {
	public class EntityRequestLogger<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse> {
		private readonly Stopwatch _stopwatch;

		private long DurationMs => _stopwatch.ElapsedMilliseconds;

		public EntityRequestLogger() => _stopwatch = new Stopwatch();

		public async Task<TResponse> Handle(TRequest requestToLog, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> task) {
			_stopwatch.Start();
			var response = await task();
			_stopwatch.Stop();

			if (DurationMs > 500) {
				Console.WriteLine($"{typeof(TRequest).Name} took {DurationMs} ms - {requestToLog}");
			}

			return response;
		}
	}
}
