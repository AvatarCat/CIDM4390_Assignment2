using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodingClubMembers.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LName {get; set;}

        [EmailAddress]
        public string Email {get; set;}

        [Display(Name = "Join Date")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}