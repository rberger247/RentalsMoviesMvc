﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalsMoviesMvc.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? IsSubscribedToNewsletter { get; set; }
    
    }
}