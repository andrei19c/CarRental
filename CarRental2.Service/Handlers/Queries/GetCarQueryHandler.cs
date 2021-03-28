using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarRental2.DataAccess.Repositories;
using CarRental2.Domain;
using CarRental2.Domain.Queries;
using MediatR;

namespace CarRental2.Service.Handlers.Queries
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, CarResponseDto>
    {
        private ICarRepository _carRepository;
        public GetCarQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<CarResponseDto> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetCar(request.CarId);
            return new CarResponseDto
            {
                Id = car.CarGroup.Id
            };
        }
    }
}
