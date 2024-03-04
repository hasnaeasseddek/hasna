using System.Net;

namespace Freelance.Application.Common.Errors;

public class InvalidEmailOrPasswordException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

    public string ErrorMessage => "Email or password is incorrect.";
}
