using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QA_app_1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        ///public string email { get; set; }
    }
}
