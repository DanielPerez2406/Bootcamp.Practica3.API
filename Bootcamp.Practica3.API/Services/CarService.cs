using Bootcamp.Practica3.API.Models;
using Bootcamp.Practica3.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API.Services
{
    public class CarService : ICarService
    {
        private ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<Car> DeleteCar(int Id)
        {
            try
            {
                _carRepository.DeleteCar(Id);

                return _carRepository.GetAllCars();
            }
            catch
            {
                return null;
            }
        }

        public bool DeleteCar2(int Id)
        {
            try
            {
                _carRepository.DeleteCar(Id);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Car EditedCar(Car car)
        {
            return _carRepository.EditedCar(car);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int Id)
        {
            return _carRepository.GetCarById(Id);
        }

        public Car SaveCar(Car car)
        {
            return _carRepository.SaveCar(car);
        }
    }
}
