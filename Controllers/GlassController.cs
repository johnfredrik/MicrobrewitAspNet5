using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MicrobrewitAspNet5.Models;
using MicrobrewitAspNet5.Repository;

namespace MicrobrewitAspNet5.Controllers
{
    [Route("api/[controller]")]
    public class GlassController : Controller
    {
       
        [FromServices]
        public IGlassRepository GlassRepository { get; set; }
        // GET: api/values
        
        [HttpGet]
        public IEnumerable<Glass> Get()
        {
            var result = GlassRepository.GetAll();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Glass Get(int id)
        {
            return GlassRepository.GetSingle(id);
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
                GlassRepository.Add(glass);              
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Glass glass)
        {
            if (glass == null) return;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
