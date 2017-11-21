﻿using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1
{
<<<<<<< HEAD
    public class Config
    {
        //clients en customize


        Secret secret = new Secret("secret".Sha256(), "2017 secret", new DateTime(2017, 11, 1));

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource("roles", new List<string> { "role" })
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("WebAPI" ) {
                    UserClaims = { "role" }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            // Clients credentials.
            return new List<Client>
            {
                // http://docs.identityserver.io/en/release/reference/client.html.
                new Client
                {
                    ClientId = "TestBackend",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword, // Resource Owner Password Credential grant.
                    AllowAccessTokensViaBrowser = true,
                    RequireClientSecret = false, // This client does not need a secret to request tokens from the token endpoint.

                    AccessTokenLifetime = 3600, // Lifetime of access token in seconds.

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId, // For UserInfo endpoint.
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        "WebAPI"
                    },
                    AllowOfflineAccess = true, // For refresh token.
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,
                    AbsoluteRefreshTokenLifetime = 7200,
                    SlidingRefreshTokenLifetime = 900,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                }


            };
        }

=======
    public class Config
    {
        //clients en customize


        Secret secret = new Secret("secret".Sha256(), "2017 secret", new DateTime(2017, 11, 1));

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource("roles", new List<string> { "role" })
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("WebAPI" ) {
                    UserClaims = { "role" }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            // Clients credentials.
            return new List<Client>
            {
                // http://docs.identityserver.io/en/release/reference/client.html.
                new Client
                {
                    ClientId = "TestBackend",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword, // Resource Owner Password Credential grant.
                    AllowAccessTokensViaBrowser = true,
                    RequireClientSecret = false, // This client does not need a secret to request tokens from the token endpoint.

                    AccessTokenLifetime = 3600, // Lifetime of access token in seconds.

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId, // For UserInfo endpoint.
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        "WebAPI"
                    },
                    AllowOfflineAccess = true, // For refresh token.
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,
                    AbsoluteRefreshTokenLifetime = 7200,
                    SlidingRefreshTokenLifetime = 900,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                }


            };
        }

>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
    }
}
