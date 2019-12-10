using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Display(Name = "Date and Time")]
        public DateTime dateTime { get; set; }
        [Display(Name = "Venue")]
        public string venue { get; set; }
        [Display(Name = "Paying Member")]
        public string payingMember { get; set; }
        [Display(Name = "Amount Paid")]
        public decimal amtPaid { get; set; }
    }
}
