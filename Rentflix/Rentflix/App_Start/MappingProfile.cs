using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Rentflix.Dtos;
using Rentflix.Models;

namespace Rentflix.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {   Mapper.CreateMap<Movie,MovieDto>().ForMember(m=>m.Id,opt	=>opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Customer, CustomerDto>().ForMember(c =>c.Id,opt =>opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}