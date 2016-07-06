using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitations.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter an email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email address")]
        public string email { get; set; }
        public string phone { get; set; }

        [Required(ErrorMessage = "Please select a response")]
        public bool? willAttend { get; set; }

    }
}