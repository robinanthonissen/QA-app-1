using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QA_app_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1.data
{
    public class ApplicationDBcontext : IdentityDbContext<ApplicationUser>
    {
<<<<<<< HEAD
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options)
            : base(options)
        {
=======
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options)
            : base(options)
        {
>>>>>>> 24111984b2c67c9d9ee1a893ac51ec75ecd1dbf4
        }
    }
}
