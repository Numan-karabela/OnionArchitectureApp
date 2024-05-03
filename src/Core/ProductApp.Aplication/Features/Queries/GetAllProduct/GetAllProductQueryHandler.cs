using AutoMapper;
using MediatR;
using ProductApp.Aplication.Dto;
using ProductApp.Aplication.İnterfaces.Repositorys;
using ProductApp.Aplication.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Features.Queries.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductResository _resository;
        IMapper mapper;

        public GetAllProductQueryHandler(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public GetAllProductQueryHandler(IProductResository resository)
        {
            _resository = resository;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        { 
            var  products = await _resository.GettAllAsync();
            
           var a= mapper.Map<List<ProductViewDto>>(products);

            return new ServiceResponse<List<ProductViewDto>>(a);


        }
    }
}
