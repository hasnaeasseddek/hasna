namespace microservice.Auth.Models.DTO
{
    public class LoginResponceDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
        public string userRole {  get; set; } 

    }
}
