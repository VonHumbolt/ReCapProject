using Business.Abstract;
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
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("addimage")]
        public IActionResult Add([FromForm(Name = "image")] IFormFile formFile, [FromForm] CarImage image)
        {
            var result = _carImageService.Add(image, formFile);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteimage")]
        public IActionResult Delete([FromForm] CarImage image)
        {
            var result = _carImageService.Delete(image);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateimage")]
        public IActionResult Update([FromForm(Name ="image")] IFormFile formFile, [FromForm] CarImage image)
        {
            var result = _carImageService.Update(formFile, image);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getImagesByCarId")]
        public IActionResult GetCarImagesById(int carId)
        {
            var result = _carImageService.GetCarImageByCarId(carId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
