using Microsoft.AspNetCore.Mvc;
using Insight.Database;
using Web.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        // GET: api/Games
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GamesDB;Integrated Security=True");
            return connection.Query<Game>("GetAllGames");
        }

        // GET api/Games/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Games
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Games/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Games/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
