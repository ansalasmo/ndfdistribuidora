using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DdfDistribuidoraApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DdfDistribuidoraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly NdfDistribuidoraContext context;

        public WeatherForecastController(NdfDistribuidoraContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<FacParametros> GetFactura()
        {
            return Ok(this.context.FacParametros.FirstOrDefault());
        }
    }
}
