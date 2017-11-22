using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1.Models.PostModels
{
    public class LoginUserModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool remember { get; set; }
    }
}
