using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Car car = await _dbContext.Cars.Where(x => x.Id == id).FirstOrDefaultAsync();
            return car;
        }
    }
}
