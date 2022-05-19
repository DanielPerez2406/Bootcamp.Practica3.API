using Bootcamp.Practica3.API.Models;
using Bootcamp.Practica3.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API.Controllers
{
    [EnableCors("Bootcamp")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<List<Car>> GetAllCars()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _carService.GetAllCars());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _carService.GetCarById(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        [Route("saveCar")]
        public ActionResult<Car> SaveCar([FromBody] Car car)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _carService.SaveCar(car));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult<Car> EditedCar ([FromBody] Car car)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _carService.EditedCar(car));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult<List<Car>> DeleteCar ([FromBody] int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _carService.DeleteCar(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> DeleteCar2(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _carService.DeleteCar2(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
