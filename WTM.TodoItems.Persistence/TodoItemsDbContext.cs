using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTM.TodoItems.Domain;

namespace WTM.TodoItems.Persistence
{
    public class TodoItemsDbContext : DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "TodoItemsDb");
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
