using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionWork
{
    internal class User
    {
        [Required(ErrorMessage ="Username is Required!")]
        [StringLength(20,ErrorMessage ="Username should be upto 20 characters only")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required!")]
        [StringLength(20, ErrorMessage = "Password should be between 6 and 20 characters.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Email is required!")]
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Date of Birth is required!")]
        public DateTime DateOfBirth { get; set; }

        public string ValidateAge()
        {
            if (DateOfBirth > DateTime.Now.AddYears(-18))
            {
                return "User must be at least 18 years old.";
            }
            return "User is valid and above 18.";
        }

    }
}
