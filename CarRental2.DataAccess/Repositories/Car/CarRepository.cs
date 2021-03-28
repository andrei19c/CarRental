using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental2.Domain.Commands;
using CarRental2.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CarRental2.DataAccess.Repositories
{
    public class CarRepository : ICarRepository
    {
        private CarRentalContext _dbContext;
        public CarRepository(CarRentalContext carRentalContext)
        {
            _dbContext = carRentalContext;
        }
        public async Task<Car> GetCar(int id)
        {
            return await _dbContext.Cars.Where(x => x.Id == id).Include(x=>x.CarGroup).FirstOrDefaultAsync();
        }

       public async Task<Car> AddCar(AddCarCommand addCarCommand)
        {
            Car car = new Car
            {
                Manufacture = addCarCommand.Manufacture,
                Model = addCarCommand.Model,
                Year = addCarCommand.Year,
                Vin = addCarCommand.Vin,
                Description = addCarCommand.Description,
                IsAvailable = addCarCommand.IsAvailable,
                CarGroupId = addCarCommand.CarGroupId,
                Observation = addCarCommand.Observation,
                StandardPrice = addCarCommand.StandardPrice,
                DateCreated = addCarCommand.DateCreated,
                CreatedBy = addCarCommand.CreatedBy
            };
            await _dbContext.AddAsync(car);
            await _dbContext.SaveChangesAsync();
            return car;
        }
    }
}
