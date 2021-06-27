using AppCurso.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCurso.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    
    {
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar (LoginViewModelInput LoginViewModelInput)
        {
            return Ok (LoginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput RegistroViewModelInput)
        {
            return Created("", RegistroViewModelInput);
        }


    }
}
