using System.Collections.Generic;

namespace FitnessClub.Models
{
    public class MembershipPlan
    {
        public int IdMembershipPlan { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public List<Customer> Customers { get; set; }
    }
}