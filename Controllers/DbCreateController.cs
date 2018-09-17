using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DbCreate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbCreateController : ControllerBase
    {
        private readonly DbCreateContext db;

        public DbCreateController(DbCreateContext db)
        {
            this.db = db;

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void NukeDatabase(int id)
        {
            await db.Database.EnsureDeletedAsync();
        }
    }
}
