using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RentalsMoviesMvc.Models;
using System.ComponentModel.DataAnnotations;
namespace RentalsMoviesMvc.ViewModels
{
    public class CustomerFormViewModel
    {
   [Display(Name = "Membership Type",
        Prompt = "Enter Last Name", Description = "Emp Last Name")]
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customers Customer { get; set; }

    }

}