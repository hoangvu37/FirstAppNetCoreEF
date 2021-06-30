using AutoMapper;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Mappinger
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
