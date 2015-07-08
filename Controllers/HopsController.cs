using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MicrobrewitAspNet5.Models;
using Microsoft.Data.Entity;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MicrobrewitAspNet5.Controllers
{
    [Route("api/[controller]")]
    public class HopsController : Controller
    {
        [FromServices]
        public MbContext DbContext { get; set; }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Hop> Get()
        {
            var result = DbContext.Hops.Include(h => h.Origin);
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Hop Get(int id)
        {
            return DbContext.Hops.Include(h => h.Origin).SingleOrDefault(h => h.HopId == id);
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

        // GET api/values/5
        [HttpGet("forms")]
        public IEnumerable<HopForm> GetHopForms()
        {
            return DbContext.HopForms;
        }
    }
}
