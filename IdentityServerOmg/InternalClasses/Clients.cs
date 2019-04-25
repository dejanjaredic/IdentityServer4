using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServerOmg.InternalClasses
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "oauthClient",
                    ClientName = "Example Client Credentials Client Application",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("superSecretPassword".Sha256())
                    },
                    AllowedScopes = new List<string> { "customAPI.read" }
                },

                new Client
                {
                    RequireConsent = false,
                    ClientId = "openIdConnectClient",
                    ClientName = "Example Implicit Client Application",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "role",
                        "customAPI.write"
                    },
                    RedirectUris =  { "https://127.0.0.1:53188/signin-oidc" },
                    FrontChannelLogoutUri = "https://127.0.0.1:53188/signout-oidc",
                    PostLogoutRedirectUris =  { "https://127.0.0.1:53188/signout-callback-oidc" }
                    
                },

                new Client
                {
                RequireConsent = false,
                ClientId = "secondClient",
                ClientName = "Example Implicit Client Application",
                AllowedGrantTypes = GrantTypes.Implicit,
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "role",
                    "customAPI.write"
                },
                RedirectUris =  { "https://localhost:51823/signin-oidc" },
                FrontChannelLogoutUri = "https://localhost:51823/signout-oidc",
                PostLogoutRedirectUris =  { "https://localhost:51823/signout-callback-oidc" }
                


                }
            };
        }
    }
}
