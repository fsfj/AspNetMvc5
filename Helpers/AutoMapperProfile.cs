using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvc5.Dtos;
using AutoMapper;

namespace AspNetMvc5.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public static void Run()
        {
            Mapper.Initialize(a =>
            {
                a.AddProfile<AutoMapperProfile>();
            });
        }
        public AutoMapperProfile()
        {
            CreateMap<ProductDto, ProductDto>();
        }
    }
}