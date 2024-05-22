using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuegoPago.Models;
using LuegoPago.Services;

namespace LuegoPago.Controllers.Cupones
{
    public class CuponCreateController : ControllerBase
    {
        private readonly ICuponRepository _cuponRepository;
        public CuponCreateController(ICuponRepository cuponRepository)
        {
            _cuponRepository = cuponRepository;
        }
        [HttpPost]
        [Route("api/Cupones")]
        public IActionResult Create([FromBody] Cupon cupon)
        {
            _cuponRepository.Add(cupon);
            return Ok();

        }
    }
}





// namespace LuegoPago.Controllers.Cupones
// {
//     [ApiController]
//     [Route("api/cupon")]
//     public class CuponCreateController : ControllerBase
//     {
//         private readonly ICuponRepository _cuponRepository;

//         public CuponCreateController(ICuponRepository cuponRepository)
//         {
//             _cuponRepository = cuponRepository ?? throw new ArgumentNullException(nameof(cuponRepository));
//         }

//         [HttpPost]
//         public IActionResult Create([FromBody] Cupon cupon)
//         {
//             if (cupon == null)
//             {
//                 return BadRequest("Cupon cannot be null");
//             }

//             try
//             {
//                 _cuponRepository.Add(cupon);
//                 return Ok();
//             }
//             catch (Exception ex)
//             {
//                 // Log the exception (ex) here if you have a logging mechanism
//                 return StatusCode(500, "An error occurred while processing your request.");
//             }
//         }
//     }

