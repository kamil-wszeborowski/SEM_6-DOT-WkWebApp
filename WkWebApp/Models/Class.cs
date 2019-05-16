using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WkWebApp.Models
{
    public class Class 
    {

        public int ClassId { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwę klasy.")]
        [MaxLength(1, ErrorMessage = "Nazwa klasy może składać się tylko z jednej litery."), MinLength(1, ErrorMessage = "Nazwa klasy może składać się tylko z jednej litery.")]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "Wprowadź rok rozpoczęcia nauki danej klasy.")]
        [MaxLength(4, ErrorMessage = "Rok musi składać się z 4 znaków."), MinLength(4, ErrorMessage = "Rok musi składać się z 4 znaków.")]
        [Display(Name = "Year Of Class")]
        public int Year { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data Of Creation")]
        public DateTime DateOfCreation { get; set; }


    }
}
