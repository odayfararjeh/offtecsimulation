using IdentityServer4.Models;
using IdentityServer4;

namespace OfftecIdentityServer.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "offtecApi",
                    ClientName = "ASP.NET Core Offtec Api",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> {new Secret("offtecGuide".Sha256())},
                    AllowedScopes = new List<string> { "offtecApi.read" }
                },
                new Client
                {
                    ClientId = "oidcMVCApp",
                    ClientName = "Sample ASP.NET Core MVC Web App",
                    ClientSecrets = new List<Secret> {new Secret("offtecGuide".Sha256())},

                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = new List<string> {"https://localhost:44346/signin-oidc"},
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "role",
                        "offtecApi.read"
                    },
                    RequirePkce = true,
                    AllowPlainTextPkce = false
                }
            };
        }
    }
}
