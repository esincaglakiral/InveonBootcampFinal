using Duende.IdentityServer.Models;
using Duende.IdentityServer;

namespace Inveon.Services.Identity
{
    public static class SD
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope> {
                new ApiScope("inveon", "Inveon Server"),
                new ApiScope(name: "read",   displayName: "Veri Okuyabilir."),
                new ApiScope(name: "write",  displayName: "Veri Yazabiliri"),
                new ApiScope(name: "delete", displayName: "Veri Silebilir")
        };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId="client",
                    ClientSecrets= { new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes={ "read", "write","profile"}
                },
                new Client
                {
                    ClientId = "inveon",
                    ClientSecrets= { new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = { 
                        "http://localhost:3000/callback"
                    },
                    PostLogoutRedirectUris = { "http://localhost:3000/" },
                    AllowedCorsOrigins = {"http://localhost:3000"},
                    AllowedScopes=new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "inveon"
                    }
                },
            };
    }
}
