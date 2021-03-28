using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarRental2.Domain.Queries
{
    public class GetCarQuery : IRequest<CarResponseDto>
    {
        public int CarId { get; set; }
    }
}
