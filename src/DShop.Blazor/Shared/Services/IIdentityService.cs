using System.Threading.Tasks;
using DShop.Blazor.Shared.Models;

namespace DShop.Blazor.Shared.Services
{
    public interface IIdentityService
    {
        Identity CreateDefaultIdentity();
        Task SignUpAsync(Identity identity);
        Task<IdentityTokens> SignInAsync(Identity identity);
    }
}