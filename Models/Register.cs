using System;
using System.ComponentModel.DataAnnotations;

namespace loginReg.Models{

    public class userRegister {
        
        [Required]
        [Display(Name ="First Name: ")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage="Name can only contain letters")]
        public string firstName {get;set;}
        
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
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password {get;set;}

    }
}