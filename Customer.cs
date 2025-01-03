using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionWork
{
    internal class Customer
    {
        [Required(ErrorMessage ="First Name is required!")]
        [StringLength(50,ErrorMessage ="Maximum allowed characters is 50")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(50, ErrorMessage = "Maximum allowed characters is 50")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Phone number is required")]
        [Phone(ErrorMessage ="Phone number is not valid!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        public string Email { get; set; }

    }
}
