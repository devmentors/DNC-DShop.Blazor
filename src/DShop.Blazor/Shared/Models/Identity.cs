namespace DShop.Blazor.Shared.Models
{
    public sealed class Identity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role = "admin";
    }
}