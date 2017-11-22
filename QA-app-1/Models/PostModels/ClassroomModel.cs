using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1.Models.PostModels
{
    public class ClassroomModel
    {
        [Key]
        public int classroomId { get; set; }
        public int userId { get; set; }
        public string subject { get; set; }
        public string timeStamp { get; set; }
        public string school { get; set; }
        public int subjectRate { get; set; }
    }
}
