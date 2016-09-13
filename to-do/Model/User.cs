﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace to_do.Model
{
  public class User
  {
    [Key]
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public string Email { get; set; }

    public IList<ToDo> ToDoItems { get; set; }

  }
}
