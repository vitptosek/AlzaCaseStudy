using MediatR;

namespace WebApi.Controllers.Interfaces {

	public interface IBaseController {
		IMediator ServiceRequest { get; }
	}
}
