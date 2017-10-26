using System.ComponentModel.DataAnnotations;

namespace loginReg.Models
{

    public class Register {
        
        [Required]
        [Display(Name ="First Name: ")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage= "Name can only contain letters")]
        public string FirstName {get;set;}
        
        [Required]
        [Display(Name ="Last Name: ")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage="Name can only contain letters")]
        public string lastName {get;set;}

        [Required]
        [Display(Name = "Email: ")]
        [EmailAddress]
        public string email {get;set;}

        [Required]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string password {get;set;}

        [Required]
        [Display(Name = "Confirm Password: ")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Compare("password")]
        public string confirm {get;set;}

    }
}