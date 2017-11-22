<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
using Microsoft.AspNetCore.Identity;
using QA_app_1.Models;
using QA_app_1.Models.PostModels;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
namespace QA_app_1.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

<<<<<<< HEAD
=======
=======
namespace QA_app_1.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

<<<<<<< HEAD
        }

        [HttpGet("GetUser")]
=======
<<<<<<< HEAD
        }

        [HttpGet("GetUser")]
=======
        }

        [HttpGet("GetUser")]
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
        public async Task<IActionResult> getuser()
        {
            var user = await _userManager.GetUserAsync(User);

            return new JsonResult(user);
<<<<<<< HEAD
        }

        [HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> login([FromBody] LoginUserModel model)
        {
            //ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
               /* var result = await _userManager.CheckPasswordAsync(model.email,
                   model.password, model.remember, lockoutOnFailure: false);
                var result2 = await _userManager.PasswordSignInAsync(model.email,
            model.password, model.remember, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    //_logger.LogInformation(1, "User logged in.");
                    return new OkObjectResult("User ingelogd");
                }*/
                //else
                //{
                    return new BadRequestObjectResult("passwoord of username verkeerd");
                //}
            }

            // If we got this far, something failed, redisplay form
            return new BadRequestObjectResult("failed");
=======
<<<<<<< HEAD
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
        }

        //[AllowAnonymous]
        [HttpPost("CreateUser")]
<<<<<<< HEAD
=======
=======
        }

        //[AllowAnonymous]
        [HttpPost("CreateUser")]
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
        public async Task<IActionResult> createuser([FromBody] CreateUserModel model)
        {
            try
            {
                var user = new ApplicationUser
                {
                    UserName = model.username,
<<<<<<< HEAD
                    voornaam = model.firstName,
                    achternaam = model.lastName,
                    Email = model.email
=======
<<<<<<< HEAD
                    voornaam = model.firstName,
                    achternaam = model.lastName,
                    Email = model.email
=======
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
                };

                if (model.password1 != model.password2)
                {
                    return new BadRequestObjectResult("passwoorden zijn niet gelijk");
                }

                var result = await _userManager.CreateAsync(user, model.password1);

                if (result.Succeeded)
                {
                    var toegevoegdeUser = await _userManager.FindByIdAsync(user.Id);
                    var assignUserToRole = await _userManager.AddToRoleAsync(toegevoegdeUser, "user");

                    if (assignUserToRole.Succeeded)
                    {
                        return new OkObjectResult("User toegevoegd aan role");
                    }

                }

                return new BadRequestObjectResult("failed");
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.ToString());
            }
<<<<<<< HEAD
        }
    }
=======
<<<<<<< HEAD
        }
    }
=======
        }
    }
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
}