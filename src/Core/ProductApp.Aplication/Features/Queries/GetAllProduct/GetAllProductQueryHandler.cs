using MediatR;
using ProductApp.Aplication.Dto;
using ProductApp.Aplication.İnterfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Features.Queries.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<ProductViewDto>>
    {
        private readonly IProductResository _resository;

        public GetAllProductQueryHandler(IProductResository resository)
        {
            _resository = resository;
        }

        public async Task<List<ProductViewDto>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {

            var  products = await _resository.GettAllAsync();
            
            return products.Select(i => new ProductViewDto()
            {
                name = i.Name,
            }).ToList();
         
          
        }
    }
}
