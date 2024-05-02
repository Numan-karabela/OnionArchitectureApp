using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Mapping
{
    public class GenericMapping:Profile
    {
        public GenericMapping()
        {
            CreateMap<Domain.Entities.Product, Dto.ProductViewDto>().ReverseMap();


        }


    }
}
