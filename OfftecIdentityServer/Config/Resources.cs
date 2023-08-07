using IdentityServer4.Models;

namespace OfftecIdentityServer.Config
{
    public class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                    {
                        Name = "role",
                        UserClaims = new List<string> {"role"}
                    }
            };
        }
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource
                {
                    Name = "offtecApi",
                    DisplayName = "Offtec Api",
                    Description = "Allow the application to access Offtec Api on your behalf",
                    Scopes = new List<string> { "offtecApi.read", "offtecApi.write"},
                    ApiSecrets = new List<Secret> {new Secret("offtecGuide".Sha256())},
                    UserClaims = new List<string> {"role"}
                }
            };
        }
    }
}
