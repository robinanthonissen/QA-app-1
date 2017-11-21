<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
using Microsoft.AspNetCore.Identity;
using QA_app_1.Models;
using QA_app_1.Models.PostModels;

<<<<<<< HEAD
namespace QA_app_1.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

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
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

<<<<<<< HEAD
        }

        [HttpGet("GetUser")]
=======
        }

        [HttpGet("GetUser")]
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
        public async Task<IActionResult> getuser()
        {
            var user = await _userManager.GetUserAsync(User);

            return new JsonResult(user);
<<<<<<< HEAD
        }

        //[AllowAnonymous]
        [HttpPost("CreateUser")]
=======
        }

        //[AllowAnonymous]
        [HttpPost("CreateUser")]
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
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
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
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
        }
    }
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
}