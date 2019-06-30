using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class Gym
    {
        [Key]
        public int IdGym { get; set; }
        [Required]
        [MaxLength(240)]
        public string Name { get; set; }
        [Required]
        [MaxLength(240)]
        public string City { get; set; }
        [Required]
        [MaxLength(480)]
        public string Address { get; set; }
        [Required]
        [MaxLength(240)]
        public string WorkingHours { get; set; }
        [Required]
        [MaxLength(480)]
        public string Contact { get; set; }
        
        public List<Customer> Customers { get; set; }
        public List<Trainer> Trainers { get; set; }
    }
}