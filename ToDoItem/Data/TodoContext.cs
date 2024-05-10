﻿using Microsoft.EntityFrameworkCore;
using ToDoItem.Model;

namespace ToDoItem.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
