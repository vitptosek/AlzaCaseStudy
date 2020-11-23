using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using MediatR;

using Logging.Interfaces;

using Domain.Entities.Common;

namespace WebApi.Controllers {

	[ApiController]
	[Route("api/v{version:apiVersion}/[controller]/[action]")]
	public abstract class BaseController<T> : ControllerBase where T : AuditableEntity {
		private IMediator _mediator;

		protected readonly Stopwatch _stopWatch;

		protected IRequestLogger<T> Logger { get; private set; }

		protected long DurationMs => _stopWatch.ElapsedMilliseconds;
		protected string AccessorIp => Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
		protected IMediator ServiceRequest => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

		public BaseController(IRequestLogger<T> logger) {
			Logger = logger;
			_stopWatch = new Stopwatch();
		}
	}
}
