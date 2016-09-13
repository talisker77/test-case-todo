using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace to_do.Model
{
  public class ToDoType
  {
    [Key]
    public Guid Id { get; set; }
    public string Description { get; set; }
  }
}
