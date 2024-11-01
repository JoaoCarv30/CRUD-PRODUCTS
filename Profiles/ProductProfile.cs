using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProductsCrud.Data.Dtos;
using ProductsCrud.Models;

namespace ProductsCrud.Profiles
{
    public class ProductProfile : Profile
    {

        public ProductProfile()
        {
            CreateMap<CreateProductDto, Product>();
            // Mapeia o objeto CreateProductDto para o objeto Product ou seja mapeia o DTO para o modelo
        }
        
    }
}