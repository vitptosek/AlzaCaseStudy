using Microsoft.Extensions.Logging;

namespace Logging.Interfaces {

	public interface IRequestLogger<out T> : ILogger<T> {
		public void LogRequest(string origin, string message, int count = 0, long durationMs = 0, LogLevel logLevel = LogLevel.Information);
	}
}
