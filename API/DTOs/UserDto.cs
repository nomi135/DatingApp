namespace API.DTOs
{
    public class UserDto
    {
        public required string username { get; set; }
        public required string Token { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
