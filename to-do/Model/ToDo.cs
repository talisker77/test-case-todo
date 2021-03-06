﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace to_do.Model
{
  public class ToDo
  {
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public ToDoType ToDoType { get; set; }
  }
}
