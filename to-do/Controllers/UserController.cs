using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using to_do.Store;
using to_do.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace to_do
{
  [Route("api/[controller]")]
  public class UserController : Controller
  {

    private readonly StoreContext _store;

    public UserController(StoreContext store)
    {
      _store = store;
    }
    // GET: api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public User Get(string id)
    {
      var user = _store
        .Users
        .FirstOrDefault(u => u.UserName == id);
      return user;
    }

    // POST api/user
    [HttpPost]
    public void Post([FromBody]User value)
    {
      if (!_store.Users.Any(u => u.UserName == value.UserName))
      {
        value.Id = Guid.NewGuid();
        value.ToDoItems = new List<ToDo>();
        _store.Users.Add(value);
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
