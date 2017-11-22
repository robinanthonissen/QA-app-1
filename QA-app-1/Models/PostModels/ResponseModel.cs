using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1.Models.PostModels
{
    public class ResponseModel
    {
        [Key]
        public string responseType { get; set; }
        public int userId { get; set; }
        public string content { get; set; }
        public string timeStamp { get; set; }
        public int likeCount { get; set; }
    }
}
