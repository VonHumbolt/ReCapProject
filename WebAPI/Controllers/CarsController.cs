﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
        
            return BadRequest(result);
           
        }
        [HttpGet("getbyId")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getimages")]
        public IActionResult GetCarImages(int carId)
        {
            var result = _carService.GetCarImages(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarsByBrandId")]
        public IActionResult GetCarsByBrandId(int brandId)
        {
            var result = _carService.GetCarsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarsByColorId")]
        public IActionResult GetCarsByColorId(int colorId)
        {
            var result = _carService.GetCarsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarDetailDtos")]
        public IActionResult GetCarDetailDtos()
        {
            var result = _carService.GetCarDetailDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarDetailByColorId")]
        public IActionResult GetCarDetailByColorId(int colorId)
        {
            var result = _carService.GetCarDetailByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("getCarDetailByBrandId")]
        public IActionResult GetCarDetailByBrandId(int brandId)
        {
            var result = _carService.GetCarDetailByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarImagesByCarId")]
        public IActionResult GetCarImagesByCarId(int carId)
        {
            var result = _carService.GetCarDetailByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("filterCarDetail")]
        public IActionResult FilterCarDetailByColorAndBrandId(int colorId, int brandId)
        {
            var result = _carService.FilterCarDetailByColorAndBrandId(colorId, brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
      
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transaction")]
        public IActionResult AddTransaction(Car car)
        {
            var result = _carService.AddTransactionalTest(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
