using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] MathRequest request)
        {
            try
            {
                var result = request.FirstVal + request.SecondVal;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public class MathRequest
        {
            public int FirstVal { get; set; }
            public int SecondVal { get; set; }
        }
    }


}
