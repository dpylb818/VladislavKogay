using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Models;

namespace lab1.Interfaces
{
    public interface IСarRepository
    {
        void SaveCar(Car car);
        IEnumerable<Car> CarList();
        Car GetCar(int CarYear);
    }
}
