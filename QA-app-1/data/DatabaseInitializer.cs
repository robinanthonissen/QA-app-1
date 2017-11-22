using Microsoft.AspNetCore.Identity;
using QA_app_1.Models;
using IdentityModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QA_app_1.data
{
    public class DatabaseInitializer : IDBInitializer
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
        private readonly ApplicationDBcontext context;
        private readonly UserManager<ApplicationUser> usermanager;
        private readonly RoleManager<IdentityRole> rolemanager;

        public DatabaseInitializer(UserManager<ApplicationUser> usermanager, RoleManager<IdentityRole> rolemanager, ApplicationDBcontext context)
        {

            this.usermanager = usermanager;
            this.rolemanager = rolemanager;
            this.context = context;

            Initialize(context).Start();

        }


        

        public async Task Initialize(ApplicationDBcontext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return; // Db has been seeded.
            }

            await rolemanager.CreateAsync(new IdentityRole("administrator"));
            await rolemanager.CreateAsync(new IdentityRole("user"));


            var user = new ApplicationUser
            {
                voornaam = "Robin",
                achternaam = "Anthonissen",
                AccessFailedCount = 0,
                Email = "robinanthonissen@hotmail.com",
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = "INFO@QA-APP.BE",
                NormalizedUserName = "INFO@QA-APP.BE",
                TwoFactorEnabled = false,
                UserName = "robinanthonissen@hotmail.com"
            };

            var result = await usermanager.CreateAsync(user, "Test123!");

            if (result.Succeeded)
            {
                var adminUser = await usermanager.FindByNameAsync(user.UserName);
                // Assigns the administrator role.
                await usermanager.AddToRoleAsync(adminUser, "administrator");
                // Assigns claims.
                var claims = new List<Claim> {
                    new Claim(type: JwtClaimTypes.GivenName, value: user.voornaam),
                    new Claim(type: JwtClaimTypes.FamilyName, value: user.achternaam),
                };
                await usermanager.AddClaimsAsync(adminUser, claims);
            }
            else
            {
                Debug.WriteLine(result.ToString());
            }

            user = new ApplicationUser
            {
                voornaam = "test",
                achternaam = "user",
                AccessFailedCount = 0,
                Email = "user@hotmail.com",
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = "INFO@QA-APP.BE",
                NormalizedUserName = "INFO@QA-APP.BE",
                TwoFactorEnabled = false,
                UserName = "Test_User"
            };

            result = await usermanager.CreateAsync(user, "Test123!");

            if (result.Succeeded)
            {
                var adminUser = await usermanager.FindByNameAsync(user.UserName);
                // Assigns the administrator role.
                await usermanager.AddToRoleAsync(adminUser, "user");
                // Assigns claims.
                var claims = new List<Claim> {
                    new Claim(type: JwtClaimTypes.GivenName, value: user.voornaam),
                    new Claim(type: JwtClaimTypes.FamilyName, value: user.achternaam),
                };
                await usermanager.AddClaimsAsync(adminUser, claims);
            }
            else
            {
                Debug.WriteLine(result.ToString());
<<<<<<< HEAD
=======
=======
        private readonly ApplicationDBcontext context;
        private readonly UserManager<ApplicationUser> usermanager;
        private readonly RoleManager<IdentityRole> rolemanager;

        public DatabaseInitializer(UserManager<ApplicationUser> usermanager, RoleManager<IdentityRole> rolemanager)
        {

            this.usermanager = usermanager;
            this.rolemanager = rolemanager;

        }

        public async Task Initialize(ApplicationDBcontext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return; // Db has been seeded.
            }

            await rolemanager.CreateAsync(new IdentityRole("administrator"));
            await rolemanager.CreateAsync(new IdentityRole("user"));


            var user = new ApplicationUser
            {
                voornaam = "Robin",
                achternaam = "Anthonissen",
                AccessFailedCount = 0,
                Email = "robinanthonissen@hotmail.com",
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = "INFO@QA-APP.BE",
                NormalizedUserName = "INFO@QA-APP.BE",
                TwoFactorEnabled = false,
                UserName = "robinanthonissen@hotmail.com"
            };

            var result = await usermanager.CreateAsync(user, "Test123!");

            if (result.Succeeded)
            {
                var adminUser = await usermanager.FindByNameAsync(user.UserName);
                // Assigns the administrator role.
                await usermanager.AddToRoleAsync(adminUser, "administrator");
                // Assigns claims.
                var claims = new List<Claim> {
                    new Claim(type: JwtClaimTypes.GivenName, value: user.voornaam),
                    new Claim(type: JwtClaimTypes.FamilyName, value: user.achternaam),
                };
                await usermanager.AddClaimsAsync(adminUser, claims);
            }
            else
            {
                Debug.WriteLine(result.ToString());
            }

            user = new ApplicationUser
            {
                voornaam = "test",
                achternaam = "user",
                AccessFailedCount = 0,
                Email = "user@hotmail.com",
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = "INFO@QA-APP.BE",
                NormalizedUserName = "INFO@QA-APP.BE",
                TwoFactorEnabled = false,
                UserName = "Test_User"
            };

            result = await usermanager.CreateAsync(user, "Test123!");

            if (result.Succeeded)
            {
                var adminUser = await usermanager.FindByNameAsync(user.UserName);
                // Assigns the administrator role.
                await usermanager.AddToRoleAsync(adminUser, "user");
                // Assigns claims.
                var claims = new List<Claim> {
                    new Claim(type: JwtClaimTypes.GivenName, value: user.voornaam),
                    new Claim(type: JwtClaimTypes.FamilyName, value: user.achternaam),
                };
                await usermanager.AddClaimsAsync(adminUser, claims);
            }
            else
            {
                Debug.WriteLine(result.ToString());
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
            }
        }
    }
}
