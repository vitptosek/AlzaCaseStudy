using Microsoft.Extensions.Logging;

using Logging.Interfaces;

namespace Logging {

	public class RequestLogger<T> : Logger<T>, IRequestLogger<T> {
		private readonly ILogger<T> _logger;

		public RequestLogger(ILoggerFactory factory) : base(factory) {
			_logger = factory.CreateLogger<T>();
		}

		public void LogRequest(string origin, string message, int count = 0, long durationMs = 0, LogLevel logLevel = LogLevel.Information) {
			message += $" - request from {origin}";

			switch (logLevel) {
				case LogLevel.Error:
					_logger.LogError(message);
					break;
				case LogLevel.Trace:
					_logger.LogTrace(message);
					break;
				case LogLevel.Debug:
					_logger.LogDebug(message);
					break;
				case LogLevel.Warning:
					_logger.LogWarning(message);
					break;
				case LogLevel.Critical:
					_logger.LogCritical(message);
					break;
				default:
					_logger.LogInformation(message);
					break;
			}
		}
	}
}
