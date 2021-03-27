using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental2.Domain.Models;
using CarRental2.Domain.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CarRental2.Api.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet("car/{id}")]
        public async Task<ActionResult<List<CarResponseDto>>> GetCars([FromRoute]string id)
        {
            GetCarQuery getCarQuery = new GetCarQuery
            {
                CarId = id
            };
            return Ok(await Mediator.Send(getCarQuery));
        }
    }
}
