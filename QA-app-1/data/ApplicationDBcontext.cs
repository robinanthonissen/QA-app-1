using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QA_app_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using QA_app_1.Models.PostModels;
=======
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696

namespace QA_app_1.data
{
    public class ApplicationDBcontext : IdentityDbContext<ApplicationUser>
    {
<<<<<<< HEAD
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options)
            : base(options)
        {
        }
        public DbSet<QA_app_1.Models.PostModels.ClassroomModel> ClassroomModel { get; set; }
        public DbSet<QA_app_1.Models.PostModels.ResponseModel> ResponseModel { get; set; }
=======
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
>>>>>>> 96852c35dd925ce88d8bb1d7924ea113a38be696
    }
}
