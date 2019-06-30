using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        [Required]
        [MaxLength(120)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(120)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        public int IdMembershipPlan { get; set; }
        public MembershipPlan MembershipPlan { get; set; }
        
        public int IdGym { get; set; }
        public Gym Gym { get; set; }
    }
}