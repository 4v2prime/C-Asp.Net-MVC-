using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation_UsingDataAnotations.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nmae is must")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is mandatory")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Email must be valida email..!")]
        public string Email { get; set; }
        public string Gender {  get; set; }
        [Required(ErrorMessage ="Password is Must")]
        //[DataType(DataType.Password)]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8-15}$", ErrorMessage = "Password must meet requirements")]
        public string Password { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

    }
    
}