using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodolistAPI_CRUD.Models;

namespace TodolistAPI_CRUD.Data
{
    public class TodolistAPI_CRUDContext : DbContext
    {
        public TodolistAPI_CRUDContext (DbContextOptions<TodolistAPI_CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<TodolistAPI_CRUD.Models.TodoItem> TodoItem { get; set; } = default!;
        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is TodoItem && e.State == EntityState.Modified);

            foreach (var entityEntry in entries)
            {
                var todoItem = (TodoItem)entityEntry.Entity;
                todoItem.DateModified = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
