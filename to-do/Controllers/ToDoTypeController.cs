using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using to_do.Store;
using to_do.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace to_do.Controllers
{


  [Route("api/[controller]")]
  public class ToDoTypeController : Controller
  {
    private readonly StoreContext _store;
    public ToDoTypeController(StoreContext store)
    {
      _store = store;
    }
    // GET: api/values
    [HttpGet]
    public IEnumerable<ToDoType> Get()
    {
      return _store.ToDoTypes.AsEnumerable();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ToDoType Get(string id)
    {
      var guid = Guid.Parse(id);
      return _store.ToDoTypes.FirstOrDefault(t => t.Id == guid);
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]ToDoType value)
    {
      if (!_store.ToDoTypes.Any(t => t.Description == value.Description))
      {
        value.Id = Guid.NewGuid();
        _store.ToDoTypes.Add(value);
        _store.SaveChanges();
      }
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
  }
}
