using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WkWebApp.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }

        [Required(ErrorMessage = "Wprowadć imię użytkownika.")]
        [StringLength(100, ErrorMessage = "Maksymalnie 100 znaków.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wprowadć nazwisko użytkownika.")]
        [StringLength(100, ErrorMessage = "Maksymalnie 100 znaków.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get{return LastName + ", " + FirstName;} }

        [StringLength(200, ErrorMessage = "E-mail może zawierać maksymalnie 200 znaków.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [MaxLength(12,ErrorMessage ="Numer telefonu może zawierać maksymalnie 12 znaków"),MinLength(6, ErrorMessage = "Numer telefonu musi zawierać minimum 6 znaków")]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Data Of Creation")]
        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "Wprowadć numer nazwę użytkownika.")]
        [StringLength(30,ErrorMessage = "Nazwa użytkownika musi zawierać się w przedziale od 6 do 30 znaków.", MinimumLength = 6)]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "Hasło musi zawirać się w przedziale od 6 do 18 znaków", MinimumLength = 6)]
        //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$"]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name ="Is Active")]
        public bool IsActive { get; set; }

    }
}
