using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LDSGems.Models;
using LDSGems.Data;

namespace LDSGems.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private LDSGemsContext _context;

        public ValuesController(LDSGemsContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(List<DailyGems>), 200)]
        public IEnumerable<DailyGems> Get()
        {
            return _context.DailyGems.ToList();
            // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
