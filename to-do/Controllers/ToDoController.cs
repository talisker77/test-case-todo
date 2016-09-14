using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using to_do.Store;
using to_do.Model;
using System;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace to_do.Controllers
{
  [Route("api/[controller]")]
  public class ToDoController : Controller
  {
    private readonly StoreContext _store;

    public ToDoController(StoreContext store)
    {
      _store = store;
    }
    // GET: api/todo
    [HttpGet]
    public IEnumerable<ToDo> Get()
    {
      return _store
        .ToDoItems
        .Include(i=>i.ToDoType)
        .AsEnumerable();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]User user)
    {
      var use = _store.Users.FirstOrDefault(u => u.UserName == user.UserName);
      //t
      if (use != null)
      {
        user.ToDoItems.ToList().ForEach(i => {
          if (use.ToDoItems == null)
          {
            use.ToDoItems = new List<ToDo>();
          }
          i.Id = Guid.NewGuid();
          use.ToDoItems.Add(i);
        });
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
