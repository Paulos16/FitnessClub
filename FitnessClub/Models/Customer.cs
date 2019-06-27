using System;

namespace FitnessClub.Models
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public int IdMembershipPlan { get; set; }
        public MembershipPlan MembershipPlan { get; set; }
    }
}