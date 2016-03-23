using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public string WhereCarProduce { get; set; }
        public Car() { }
        public Car(string CarModel, int CarYear, string WhereCarProduce)
        {
            this.CarModel = CarModel;
            this.CarYear = CarYear;
            this.WhereCarProduce = WhereCarProduce;
        }
    }
}