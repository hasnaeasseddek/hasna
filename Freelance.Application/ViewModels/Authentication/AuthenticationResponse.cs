namespace Freelance.Application.ViewModels.Authentication;


public class AuthenticationResponse
{
    public int Id { get; set; }
    public string Message { get; set; }
    public bool ISAuthenticated { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<string> Roles { get; set; }
    public string Token { get; set; }
    public DateTime ExpiresOn { get; set;}

}
