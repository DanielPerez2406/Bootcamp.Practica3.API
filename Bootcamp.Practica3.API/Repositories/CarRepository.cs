using Bootcamp.Practica3.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext context;

        public CarRepository(CarContext _context)
        {
            context = _context;
        }

        public void DeleteCar(int Id)
        {
            context.Car.Remove(context.Car.Find(Id));
            context.SaveChanges();
        }

        public Car EditedCar(Car car)
        {
            Car editedCar = context.Car.Find(car.Id);
            if (editedCar == null)
                return null;

            editedCar.Placa = car.Placa;
            editedCar.Marca = car.Marca;
            editedCar.Modelo = car.Modelo;
            editedCar.Año = car.Año;
            editedCar.Dueño_Nombre = car.Dueño_Nombre;
            editedCar.Dueño_Apellido = car.Dueño_Apellido;
            editedCar.Dueño_Edad = car.Dueño_Edad;

            context.Car.Update(editedCar);
            context.SaveChanges();

            return editedCar;
        }

        public List<Car> GetAllCars()
        {
            return context.Car.ToList();
        }

        public Car GetCarById(int Id)
        {
            return context.Car.Find(Id);
        }

        public Car SaveCar(Car car)
        {
            context.Car.Add(car);
            context.SaveChanges();
            return car;
        }
    }
}
