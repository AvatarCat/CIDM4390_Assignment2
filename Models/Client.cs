using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodingClubMembers.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name = "Company")]
        [Required]
        public string CName { get; set; }

        [EmailAddress]
        public string Email {get; set;}

        [Display(Name = "Phone Number")]
        [Phone]
        public string Number { get; set; }
    }
}