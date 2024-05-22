using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuegoPago.Models;
using LuegoPago.Services;
using Microsoft.AspNetCore.Http.HttpResults;
namespace LuegoPago.Controllers.Cupones
{
    public class CuponUpdateController : ControllerBase
    {
        private readonly ICuponRepository _cuponRepository;
        public CuponUpdateController(ICuponRepository cuponRepository)
        {
            _cuponRepository = cuponRepository;
        }
        [HttpPut("{id}")]
        [Route("api/cupones/update/{id}")]
        public string Update(int id, [FromBody] Cupon cupon)
        {
            var cuponId = _cuponRepository.GetById(id);

            cuponId.Nombre = cupon.Nombre;
            cuponId.Descripcion = cupon.Descripcion;
            cuponId.FechaInicio = cupon.FechaInicio;
            cuponId.FechaFin = cupon.FechaFin;
            cuponId.ValorDescuento = cupon.ValorDescuento;
            cuponId.Usabilidad = cupon.Usabilidad;
            cuponId.Estado = cupon.Estado;



            _cuponRepository.Update(cuponId );

            return "cupon " + cuponId;
        }

    }




  }
   
