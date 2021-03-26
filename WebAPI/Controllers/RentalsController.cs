using Business.Abstract;
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
                    return Ok(result);
                }
                return BadRequest(result);
            }
        }
}
