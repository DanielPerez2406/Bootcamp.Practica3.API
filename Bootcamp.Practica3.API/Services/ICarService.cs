using Bootcamp.Practica3.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API.Services
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int Id);
        Car SaveCar(Car car);
        Car EditedCar(Car car);
        List<Car> DeleteCar(int Id);
        bool DeleteCar2(int Id);    }
}
