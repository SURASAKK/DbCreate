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

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void NukeDatabase(int id)
        {
            await db.Database.EnsureDeletedAsync();
        }
    }
}
