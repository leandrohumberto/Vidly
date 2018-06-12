using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        // [Range(typeof(DateTime), "1/1/1800", "12/31/2999", ErrorMessage = "Value for date of birth must be between {1} and {2}")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; } // Navigation Property

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}