using System.Threading.Tasks;

namespace DShop.Blazor.Shared.Services
{
    public interface IAuthService
    {
        Task SetAccessTokenAsync(string accessToken);
        Task<string> GetAccessTokenAsync();
    }
}