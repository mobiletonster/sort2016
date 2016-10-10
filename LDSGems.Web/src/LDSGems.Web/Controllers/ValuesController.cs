﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LDSGems.Models;
using LDSGems.Data;
using LDSGems.Services;

namespace LDSGems.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private LDSGemsService _service;

        public ValuesController(LDSGemsContext context)
        {
            
            _service = new LDSGemsService(context);
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(List<DailyGems>), 200)]
        public async Task<IEnumerable<DailyGems>> Get()
        {
            return await _service.GetDailyGemsAsync();
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
