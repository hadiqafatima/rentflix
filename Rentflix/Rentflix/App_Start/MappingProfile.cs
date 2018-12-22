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
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}