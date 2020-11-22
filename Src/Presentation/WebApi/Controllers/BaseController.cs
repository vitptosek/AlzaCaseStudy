using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using MediatR;

namespace WebApi.Controllers {

	[ApiController]
	[Route("api/[controller]/[action]")]
	public abstract class BaseController : ControllerBase {
		private IMediator _mediator;

		protected string AccessorIp => Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
		protected IMediator ServiceRequest => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
	}
}
