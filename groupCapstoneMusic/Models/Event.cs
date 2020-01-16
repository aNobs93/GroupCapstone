using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace groupCapstoneMusic.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public string Venue { get; set; }

        public string Location { get; set; }

        public string Genre { get; set; }

        public string Audience { get; set; }

        [Display(Name = "Event Date")]
        public string EventDate { get; set; }

        [Display(Name = "Event Time")]
        public string EventTime { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}