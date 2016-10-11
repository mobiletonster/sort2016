using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LDSGems.Models;
using LDSGems.Data;
using LDSGems.Services;

namespace LDSGems.Web.Controllers
{
    //[Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private LDSGemsService _service;

        public ValuesController(LDSGemsContext context)
        {           
            _service = new LDSGemsService(context);
        }

        // GET api/values
        [HttpGet]
        [Route("api/dailygems")]
        [ProducesResponseType(typeof(List<DailyGems>), 200)]
        public async Task<IEnumerable<DailyGems>> Get()
        {
            return await _service.GetDailyGemsAsync();
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        [HttpGet]
        [Route("api/dailygems/{id}")]
        [ProducesResponseType(typeof(DailyGems), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> Get(int id)
        {
            if (id > 0)
            {
                return Ok(await _service.GetDailyGemByIdAsync(id));
            }
            else
            {
                var message = $"{id} is not a valid id value.";
                return BadRequest(message);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/dailygems")]
        [ProducesResponseType(typeof(DailyGems),200)]
        public async Task<IActionResult> Put([FromBody]DailyGems gem)
        {
            if (gem == null)
            {
                return BadRequest("DailyGem cannot be null");
            }
            var updated = await _service.UpdateDailyGemAsync(gem);
            return Ok(updated);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
