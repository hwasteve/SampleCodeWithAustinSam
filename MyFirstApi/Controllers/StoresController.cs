using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApi.Entity;
using MyFirstApi.Service;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        // GET: api/<StoresController>
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            StoreService MyService = new StoreService();
            return MyService.GetStores();
        }

        // GET api/<StoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            StoreService MyService = new StoreService();
            Store myStore = MyService.GetStore(id);

            if (myStore == null)
                return "";
            else
                return myStore.Name;
        }

        [HttpPost(Name ="ChangeName")]
        public Boolean UpdateName(int id, String name)
        {
            StoreService MyService = new StoreService();
            return MyService.UpdateName(id, name);
        }

        // POST api/<StoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<StoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<StoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
