﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace yembis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : ControllerBase
    {
        // GET: api/<CameraController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CameraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CameraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CameraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CameraController>/5
      /*  [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}