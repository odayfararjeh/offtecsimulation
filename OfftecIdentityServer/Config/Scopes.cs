using IdentityServer4.Models;

namespace OfftecIdentityServer.Config
{
    public class Scopes
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("offtecApi.read", "Read Access to Offtec API"),
                new ApiScope("offtecApi.write", "Write Access to Offtec API"),
            };
        }
    }
}
