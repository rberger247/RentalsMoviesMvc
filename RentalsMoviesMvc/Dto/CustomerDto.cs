using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentalsMoviesMvc.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        [Display(Name = "Membership Type",
        Prompt = "Enter Last Name", Description = "Emp Last Name")]
        public byte MembershipTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

    
    }
}