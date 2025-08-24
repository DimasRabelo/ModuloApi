using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
      [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObTerDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                hora = DateTime.Now.ToLongTimeString()
            };

            return Ok(obj);
        }

       [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Seja bem-vindo, {nome}!";
            return Ok(new { mensagem });
        }
    }
}
