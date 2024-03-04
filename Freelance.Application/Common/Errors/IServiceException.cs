using System.Net;

namespace Freelance.Application.Common.Errors;

public interface IServiceException
{
    public HttpStatusCode StatusCode { get;}
    public string ErrorMessage { get;}
}
