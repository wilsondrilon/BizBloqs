using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizBloqs.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [Route("healthcheck")]
        public IActionResult HealthCheck()
        {
            return Ok("ok");
        }
    }
}
