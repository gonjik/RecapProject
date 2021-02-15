using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
 
             new Car{ Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 10000, Description = "Mercedes S350", ModelYear = "2020"},
             new Car{ Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 9000, Description = "Audi A8 Long", ModelYear = "2020"},
             new Car{ Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 250, Description = "Fiat Egea", ModelYear = "2020"},
             new Car{ Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 600, Description = "Peogeut 3008", ModelYear = "2020"},
             new Car{ Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 900, Description = "VW Passat", ModelYear = "2020"},
             new Car{ Id = 6, BrandId = 1, ColorId = 2, DailyPrice = 2000, Description = "Mercedes C180", ModelYear = "2020"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;




        }
    }
}
