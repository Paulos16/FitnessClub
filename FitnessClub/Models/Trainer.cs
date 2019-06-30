using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class Trainer
    {
        [Key]
        public int IdTrainer { get; set; }
        [Required]
        [MaxLength(120)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(120)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(960)]
        public string Qualifications { get; set; }
        [Required]
        [MaxLength(960)]
        public string Achievements { get; set; }
        
        public int IdGym { get; set; }
        public Gym Gym { get; set; }
    }
}