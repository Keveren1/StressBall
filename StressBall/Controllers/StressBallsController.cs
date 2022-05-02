using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using StressBall.Manager;

namespace StressBall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StressBallsController : ControllerBase
    {
        private StressBallManager _manager = new StressBallManager();

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]

        public ActionResult<IEnumerable<StressBallData>> Get([FromQuery] string? accelerationFilter,
            [FromQuery] DateTime? dateTimeFilter)
        {
            IEnumerable<StressBallData> stressBalls = _manager.GetAll(accelerationFilter, dateTimeFilter);

            if (stressBalls.Count() <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(stressBalls);
            }
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            StressBallData stressBall = _manager.GetById(id);
            if (stressBall == null) return NotFound("" + id);
            return Ok(stressBall);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        public StressBallData Post(StressBallData newStressBall)
        {
            return _manager.PostStressBallData(newStressBall);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete("{id}")]
        public StressBallData Delete(int id)
        {
            StressBallData stressBall = _manager.GetById(id);
            return _manager.Delete(id);
        }
    }


}
