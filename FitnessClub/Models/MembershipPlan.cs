using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class MembershipPlan
    {
        [Key]
        public int IdMembershipPlan { get; set; }
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        [MaxLength(120)]
        public string Description { get; set; }
        
        public List<Customer> Customers { get; set; }
    }
}