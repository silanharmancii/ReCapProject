using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            RentalCar();

        }

        private static void RentalCar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in rentalManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

          
    }
}
