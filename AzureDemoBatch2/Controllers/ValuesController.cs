using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureDemoBatch2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("Student")]
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
             new Student{ Id=1, Name="Muhammad Ayaz", Email="m.ayaz@outlook.com" },
             new Student{ Id=2, Name="Dev Ayaz", Email="d.ayaz@outlook.com" },
             new Student{ Id=3, Name="Chandan Bhagat", Email="chandan.bhagat@outlook.com" },
             new Student{ Id=4, Name="Bilawal Khan", Email="b.khan@outlook.com" },
             new Student{ Id=5, Name="Haroon Iqbal", Email="h.iqbal@outlook.com" }
            };
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}