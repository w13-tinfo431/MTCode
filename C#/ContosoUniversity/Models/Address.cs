using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public abstract class Address
    {
        public int AddressId { get; set; }

        [RegularExpression("@contoso.edu", ErrorMessage = "Please enter a valid E-mail address.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

    }
}