using MediatR;
using ProductApp.Aplication.Dto;
using ProductApp.Aplication.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.Features.Queries.GetAllProduct
{
    public class GetAllProductQueryRequest:IRequest<ServiceResponse<List<ProductViewDto>>>
    {

    }
}
