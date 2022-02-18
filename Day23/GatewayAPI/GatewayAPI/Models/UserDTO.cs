namespace GatewayAPI.Models
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string? Token { get; set; }
    }
}
