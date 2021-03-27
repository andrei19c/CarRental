using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental2.Domain.Model;

namespace CarRental2.DataAccess.Repositories
{
    public interface ICarRepository
    {
        Task<Car> GetCar(int id);
    }
}
