using System;
using System.ComponentModel.DataAnnotations;

namespace MeetService.Models
{
    public class Meet
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // public User

        // public Client
    }
}