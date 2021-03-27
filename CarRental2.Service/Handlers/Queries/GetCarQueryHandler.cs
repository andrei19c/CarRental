using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarRental2.Domain.Models;
using CarRental2.Domain.Queries;
using MediatR;

namespace CarRental2.Service.Handlers.Queries
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, CarResponseDto>
    {
        public async Task<CarResponseDto> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            return new CarResponseDto
            {
                Id = request.CarId
            };
        }
    }
}
