using Business.Abstract;
using Entities.Concrete;
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

            public RentalsController(IRentalService rentalService)
            {
               _rentalService = rentalService;
            }

            [HttpGet("getall")]

            public IActionResult GetAll()
            {
                var result = _rentalService.GetAll();

                if (result.Success == true)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


            [HttpGet("getrentaldetails")]

            public IActionResult GetRentalDetails()
            {
                var result = _rentalService.GetRentalDetails();

                if (result.Success == true)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);
            }
        [HttpGet("getrentaldetailsbyid")]

        public IActionResult GetRentalDetailsById(int id)
        {
            var result = _rentalService.GetRentalDetailsById(id);

            if (result.Success == true)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getrentalbycarid")]

        public IActionResult GetRentalByCarId(int id)
        {
            var result = _rentalService.GetRentalByCarId(id);

            if (result.Success == true)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
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
    }
}
