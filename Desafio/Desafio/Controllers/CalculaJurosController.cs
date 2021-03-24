using Desafio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(double valorinicial, int meses)
        {
            return Ok(TaxaJuros.CalculaJuros(valorinicial, meses).ToString("0.00"));
        }
    }
}
