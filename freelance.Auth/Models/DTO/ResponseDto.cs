namespace freelance.Auth.Models.DTO
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public UserDto User { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";

        public string Token { get; set; }
    }
}
