using API_RESTfull_CRUD.Contexts;
using API_RESTfull_CRUD.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_RESTfull_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProductoController(AppDbContext context)
        {
            this.context = context;
        }
        
        
        // GET: api/<ProductoController>
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return context.Producto.ToList();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public Producto Get(string id)
        {
            var producto = context.Producto.FirstOrDefault(p=>p.pro_codigo==id);
            return producto;
        }

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
