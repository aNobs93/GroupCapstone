using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace groupCapstoneMusic.Models
{
    public class Musician
    {
        [Key]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Price Range")]
        public int PriceRange { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public int ID { get; set; }
        public string Bio { get; set; }
        public string Genre { get; set; }
        public double rating { get; set; }
        [Display(Name = "Set Rate")]
        public double SetRate { get; set; }
        [Display(Name = "Set Rate")]
        public string LastName { get; set; }
        [Display(Name = "Dates Available")]
        public string DatesAvailable { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}