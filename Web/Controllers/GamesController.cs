using Microsoft.AspNetCore.Mvc;
using Insight.Database;
using Web.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
//using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IDbConnection _dbConnection;

        public GamesController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            _dbConnection = new SqlConnection(connectionString);
        }

        // GET: api/Games
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return _dbConnection.Query<Game>("GetAllGames");
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
