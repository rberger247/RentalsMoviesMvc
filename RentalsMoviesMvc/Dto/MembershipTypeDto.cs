using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace RentalsMoviesMvc.Dto
{
    public class MembershipTypeDto
    {
          [Display(Name = "Membership Type",
        Prompt = "Enter Last Name", Description = "Emp Last Name")]
        public byte MemberhipTypeId { get; set; }
        public string MembershipType { get; set; }
    }
}