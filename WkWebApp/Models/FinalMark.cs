using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WkWebApp.Models
{
    public class FinalMark
    {
        public int FinalMarkId { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }

        [Display(Name ="Mark")]
        public int Mark { get; set; }


    }
}
