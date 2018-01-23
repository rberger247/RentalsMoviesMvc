using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using  System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using RentalsMoviesMvc.Dto;
using RentalsMoviesMvc.Models;

namespace RentalsMoviesMvc.Controllers.Api
{
    //[RoutePrefix("api/Customers")]
    public class CustomersController : ApiController
    {
        private RentalStoreEntities _context;

        public CustomersController()
        {
            _context = new RentalStoreEntities();
        }

        // GET /api/customers
        //[Route("/customer")]
        //[HttpGet]
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipTypes);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Customers, CustomerDto>);

            return Ok(customerDtos);
        }
    }
}
