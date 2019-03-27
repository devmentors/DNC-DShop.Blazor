using System.Threading.Tasks;
using DShop.Blazor.Shared.Services;

namespace DShop.Blazor.Shared.Components
{
    public class MainLayoutComponent
    {
        private readonly IAuthService _authService;
        private readonly IIdentityService _identityService;

        public MainLayoutComponent(IAuthService authService, IIdentityService identityService)
        {
            _authService = authService;
            _identityService = identityService;
        }

        public async Task OnInit()
        {
            var accessToken = await _authService.GetAccessTokenAsync();
            
            if (accessToken is null)
            {
                var identity = _identityService.CreateDefaultIdentity();
                await _identityService.SignUpAsync(identity);
                var tokens = await _identityService.SignInAsync(identity);
                await _authService.SetAccessTokenAsync(tokens.AccessToken);
            }
        }
    }
}