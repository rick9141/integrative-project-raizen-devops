using Microsoft.AspNetCore.Mvc;
using RaizenDevops.Models.InputModels;

namespace RaizenDevops.Controllers
{
    // api/users/5/fuels
    [Route("api/users/{userId}/fuels")]
    public class FuelsController : ControllerBase
    {
        // api/users/5/fuels - GET
        [HttpGet]
        public IActionResult GetAll(int fuellId)
        {
            return Ok();
        }

        // api/users/5/fuels/12 - GET
        [HttpGet("{fuelId}")]
        public IActionResult Get(int fuellId)
        {
            return Ok();
        }

        // api/users/5/fuels
        [HttpPost]
        public IActionResult Post([FromBody] CreateFuelInputModel inputModel)
        {
            return Ok();
        }

        // api/users/5/fuels/12 - PUT
        [HttpPut("{fuellId}")]
        public IActionResult Put(int fuellId, [FromBody] UpdateFuelInputModel inputModel)
        {
            return NoContent();
        }

        // api/users/5/fuels/12 - DELETE
        [HttpDelete]
        public IActionResult Delete(int fuellId)
        {
            return NoContent();
        }
    }
}
