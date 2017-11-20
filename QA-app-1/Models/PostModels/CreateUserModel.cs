using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1.Models.PostModels
{
    public class CreateUserModel
    {
        public string password1 { get; set; }
        public string password2 { get; set; }
        public string username { get; set; }
    }
}