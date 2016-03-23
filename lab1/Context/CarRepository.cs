using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab1.Interfaces;
using lab1.Models;

namespace lab1.Context
{
    public class CarRepository : IСarRepository  
    {
        private CarContext db = new CarContext();

        public void SaveCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
        }
        public IEnumerable<Car> CarList()
        {
            return db.Cars;
        }
        public Car GetCar(int CarYear)
        {
            var car = new Car();
            var b = db.Cars.ToList();
            for (int i = 0; i < b.Count - 1; i++)
            {
                if (b[i].CarYear.Equals(CarYear))
                {
                    car.CarModel = b[i].CarModel;
                    car.CarYear = b[i].CarYear;
                    car.WhereCarProduce = b[i].WhereCarProduce;

                }
            }
                return car;
            
        }

    }
}