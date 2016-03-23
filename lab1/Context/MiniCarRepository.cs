using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab1.Interfaces;
using lab1.Models;

namespace lab1.Context
{
    public class MiniCarRepository : IСarRepository
    {
        private List<Car> carList = new List<Car>();
        private Car car = new Car();

        public void SaveCar(Car car)
        {
            carList.Add(car);
        }
        public IEnumerable<Car> CarList()
        {
            return carList;
        }
        public Car GetCar(int CarYear)
        {
            for (int i = 0; i < carList.Count - 1;i++ )
            {
                if (carList[i].CarYear.Equals(CarYear))
                {
                    car.CarModel = carList[i].CarModel;
                    car.CarYear = carList[i].CarYear;
                    car.WhereCarProduce = carList[i].WhereCarProduce;

                }
            }
            return car;

        }
        
    }
}