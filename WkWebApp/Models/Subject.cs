using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WkWebApp.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwę przedmiotu.")]
        [MaxLength(3, ErrorMessage = "Nazwa przedmiotu musi składać się z minimum 3 znaków."), MinLength(50, ErrorMessage = "Nazwa przedmiotu musi składać się z maksymalnie 50 znaków.")]
        [Display(Name = "Class Name")]
        public string SubjectName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date Of Creation")]
        public DateTime DateOfCreation { get; set; }

        public List<Test> Tests { get; set; }

    }

    /* public class SubjectDBCtxt : DbContext
     {
         public DbSet<Subject> Subject{ get; set; }
     }*/
}

    