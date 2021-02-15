using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 3,
                CustomerId = 2,
                Id = 7,
                RentDate = DateTime.Now

            });

            foreach (var rentals in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rentals.CustomerId);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 7, ColorName = "Navy" });
            colorManager.Add(new Color { ColorId = 10, ColorName = "RedVelved" });

            foreach (var colors in colorManager.GetAll().Data)
            {
                Console.WriteLine(colors.ColorName);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var cars in carManager.GetCarsDetails().Data)
            {
                Console.WriteLine("Araç İsmi: " + cars.CarName + ",  Günlük Ücret: " + cars.DailyPrice + ",  " + "Araç Rengi: " + cars.ColorName);
                Console.WriteLine("Açıklama: " + cars.Description);
                Console.WriteLine("-------------");

            }
        }
        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Porsche", BrandId = 8 });
        }


    }
}
