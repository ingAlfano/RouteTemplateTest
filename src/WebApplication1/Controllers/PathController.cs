using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class PathController : Controller
    {
        // GET api/path/myPath
        [HttpGet("{*fullPath}")]
        public async Task<IActionResult> Get([FromQuery]string fullPath = "defaultValue")
        {
            return Ok(fullPath);
        }
    }
}
