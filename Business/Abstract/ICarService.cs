using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<Car>> GetCarsByBrandId(int brandid);
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetCarsByUnitPrice(int min);
        IDataResult<List<CarDetailDto>> GetCarsDetails();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult AddTransactionalTest(Car car);

    }
}
