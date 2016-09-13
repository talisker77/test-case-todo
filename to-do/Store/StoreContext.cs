using Microsoft.EntityFrameworkCore;
using to_do.Model;

namespace to_do.Store
{
  public class StoreContext : DbContext
  {
    //static StoreContext()
    //{
    //  Database.SetInitializer(new StoreInitializer());
    //  using (var db = new StoreContext())
    //  {
    //    try
    //    {
    //      db.Database.Initialize(true);
    //    }
    //    catch (Exception e)
    //    {

    //      var r = e;
    //    }

    //  }
    //}
    public StoreContext(DbContextOptions<StoreContext> option) : base(option)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<ToDo> ToDoItems { get; set; }

    public DbSet<ToDoType> ToDoTypes { get; set; }
  }

  //class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
  //{
  //  public override void InitializeDatabase(StoreContext context)
  //  {



  //    base.InitializeDatabase(context);
  //  }
  //}
}
