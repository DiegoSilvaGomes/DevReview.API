using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevReview.API.Entities;
using DevReview.API.Models;

namespace DevReview.API.Mappers
{
    public class ProductMappers : Profile
    {
        public ProductMappers()
        {
            CreateMap<AddProductInputModel, Product>();
        }
    }
}
