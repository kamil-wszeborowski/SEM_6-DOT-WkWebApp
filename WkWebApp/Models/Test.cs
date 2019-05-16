using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WkWebApp.Models
{
    public class Test
    {
        public int TestId { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Wprowadć nazwę testu.")]
        [StringLength(30, ErrorMessage = "Nazwa testu musi zawierać się w przedziale od 6 do 30 znaków.", MinimumLength = 6)]
        [Display(Name = "Test Name")]
        public string TestName { get; set; }

        [Display(Name = "Mark")]
        public double Mark { get; set; }

        [Display(Name = "Weight")]
        public int Weight { get; set; }

        [StringLength(300, ErrorMessage = "Maksymalnie 300 znaków.")]
        [Display(Name = "Note")]
        public string Note { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data Of Creation")]
        public DateTime DateOfCreation { get; set; }
        

    }
}
