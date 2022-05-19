using Bootcamp.Practica3.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API.Repositories
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
        Car GetCarById(int Id);
        Car SaveCar(Car car);
        Car EditedCar(Car car);
        void DeleteCar(int Id);
    }
}
