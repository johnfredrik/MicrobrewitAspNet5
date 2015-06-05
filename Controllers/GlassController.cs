using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MicrobrewitAspNet5.Models;

namespace MicrobrewitAspNet5.Controllers
{
    [Route("api/[controller]")]
    public class GlassController : Controller
    {
        [FromServices]
        public MbContext DbContext { get; set; }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Glass> Get()
        {
            var result = DbContext.Glasses;
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Glass Get(int id)
        {
            return DbContext.Glasses.SingleOrDefault(g => g.GlassId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Glass glass)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                var glassId = DbContext.Glasses.Max(g => g.GlassId) + 1;
                DbContext.Glasses.Add(glass);                
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Glass glass)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
