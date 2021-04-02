using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        IBankService _bankService;
        IUserCardDetailService _userCardDetailService;
        public RentalsController(IRentalService rentalService, IBankService bankService, IUserCardDetailService userCardDetailService)
        {
            _rentalService = rentalService;
            _bankService = bankService;
            _userCardDetailService = userCardDetailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getById")]
        public IActionResult GetByRentalId(int rentalId)
        {
            var result = _rentalService.GetRentalById(rentalId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getRentalByCarId")]
        public IActionResult GetRentalByCarId(int carId)
        {
            var result = _rentalService.GetRentalByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getRentalDetailDto")]
        public IActionResult GetRentalDetailDto()
        {
            var result = _rentalService.GetRentalDetailDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("pay")]
        public IActionResult Pay()
        {
            var result = _bankService.Pay();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getUserCardNumber")]
        public IActionResult GetUserCardNumber(int userId)
        {
            var result = _userCardDetailService.GetCarDetailByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addCardNumber")]
        public IActionResult AddUserCardNumber(UserCardDetail userCardDetail)
        {
            var result = _userCardDetailService.Add(userCardDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
