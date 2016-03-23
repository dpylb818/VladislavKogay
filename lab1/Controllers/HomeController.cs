using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab1.Context;
using lab1.Interfaces;
using lab1.Models;
using Ninject;

namespace lab1.Controllers
{
    public class HomeController : Controller
    {
        IСarRepository carConstruct;
        
       
        public HomeController(IСarRepository carConstruct)
        {      
            this.carConstruct = carConstruct;     
        }
        public ActionResult Index()
        {
           // for (int i = 0; i < 25; i++)
           // {
           //     var carModel = new Car();
           //     carModel.CarModel = "Ferrari" + i.ToString();
           //     carModel.CarYear = 1985 + i;
           //     carModel.WhereCarProduce = "USA"+i.ToString();
           //     carConstruct.SaveCar(carModel);
           // }
           // var findCar = carConstruct.GetCar("Ferrari7");
          //  var car = new Car();
          //  car.CarModel = "Lambo";
          //  car.CarYear = 1934;
          //  car.WhereCarProduce = "Italy";
          //  var list = new List<Car>();
          //  list.Add(carConstruct.GetCar(4)); //by id from DB
          // // carConstruct.SaveCar(car);
            
            return View(carConstruct.CarList());
               // return View(carConstruct.CarList());
        }

 
    }
}