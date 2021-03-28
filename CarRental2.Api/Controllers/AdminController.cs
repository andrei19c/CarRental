using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental2.Domain;
using CarRental2.Domain.Commands;
using CarRental2.Domain.Dtos;
using CarRental2.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CarRental2.Api.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet("car/{id}")]
        public async Task<ActionResult<List<CarResponseDto>>> GetCars([FromRoute]int id)
        {
            GetCarQuery getCarQuery = new GetCarQuery
            {
                CarId = id
            };
            return Ok(await Mediator.Send(getCarQuery));
        }

        [HttpPost("car")]
        public async Task<ActionResult<AddCarResponseDto>> AddCar([FromBody] AddCarRequestDto addCarRequestDto)
        {
            AddCarCommand addCarCommand = new AddCarCommand
            {
                Manufacture = addCarRequestDto.Manufacture,
                Model = addCarRequestDto.Model,
                Year = addCarRequestDto.Year,
                Vin = addCarRequestDto.Vin,
                Description = addCarRequestDto.Description,
                Observation = addCarRequestDto.Observation,
                CarGroupId = addCarRequestDto.CarGroupId,
                StandardPrice = addCarRequestDto.StandardPrice,
                IsAvailable = addCarRequestDto.IsAvailable,
                DateCreated = DateTime.UtcNow,
                CreatedBy = "admin"
            };

            return  await Mediator.Send(addCarCommand);
        }
    }
}
