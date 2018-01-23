using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RentalsMoviesMvc.Dto;
using RentalsMoviesMvc.Models;


namespace RentalsMoviesMvc.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customers, CustomerDto>();
            Mapper.CreateMap<Movies, MovieDto>();
            Mapper.CreateMap<MembershipTypes, MembershipTypeDto>();
            Mapper.CreateMap<Genres, GenreDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customers>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movies>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}