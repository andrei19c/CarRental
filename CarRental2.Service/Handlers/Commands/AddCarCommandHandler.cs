using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarRental2.DataAccess.Repositories;
using CarRental2.Domain;
using CarRental2.Domain.Commands;
using CarRental2.Domain.Dtos;
using CarRental2.Domain.Model;
using MediatR;

namespace CarRental2.Service.Handlers.Commands
{
    public class AddCarCommandHandler : IRequestHandler<AddCarCommand, AddCarResponseDto>
    {
        private ICarRepository _carRepository;
        public AddCarCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<AddCarResponseDto> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            var carAdded = await _carRepository.AddCar(request);
            AddCarResponseDto addCarResponseDto = new AddCarResponseDto
            {
                Id = carAdded.Id,
                Manufacture = carAdded.Manufacture,
                Model = carAdded.Model,
                Year = carAdded.Year,
                Vin = carAdded.Vin,
                Description = carAdded.Description,
                Observation = carAdded.Observation,
                IsAvailable = carAdded.IsAvailable,
                StandardPrice = carAdded.StandardPrice,
                CarGroupId = carAdded.CarGroupId
            };
            return addCarResponseDto;
        }
    }
}
