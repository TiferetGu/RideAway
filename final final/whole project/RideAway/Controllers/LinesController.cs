using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesController : ControllerBase
    {
        [HttpGet("{stopId}")]
        public IEnumerable<string> Get(int stopId)
        {
            return new string[] { "31", "36", "72", "71" };
        }
    }
}
