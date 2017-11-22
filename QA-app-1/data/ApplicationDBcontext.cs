using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QA_app_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QA_app_1.Models.PostModels;

namespace QA_app_1.data
{
    public class ApplicationDBcontext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options)
            : base(options)
        {
        }
        public DbSet<QA_app_1.Models.PostModels.ClassroomModel> ClassroomModel { get; set; }
        public DbSet<QA_app_1.Models.PostModels.ResponseModel> ResponseModel { get; set; }
    }
}
