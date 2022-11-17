using Microsoft.EntityFrameworkCore;
using System;
using WTM.TodoItems.Application.Interfaces;
using WTM.TodoItems.Domain;

namespace WTM.TodoItems.Persistence
{
    public class TodoItemsRespository : ITodoItemsRespository
    {
        private readonly TodoItemsDbContext _context;

        public TodoItemsRespository()
        {
            _context = new TodoItemsDbContext();

            var items = new List<TodoItem>
                {
                    new TodoItem
                    {
                        Id = 1,
                        Name ="Design WTW application tomorrow",
                        Status = TodoItemStatus.New

                    },
                   new TodoItem
                    {
                        Id = 2,
                        Name ="Attend WTW design meeting",
                        Status = TodoItemStatus.New

                    }
                };
            _context.TodoItems.AddRange(items);
            _context.SaveChanges();
        }

        public async Task<int> Add(TodoItem newItem)
        {
            var result = await _context.AddAsync(newItem);
            return result.Entity.Id;
        }

        public async Task<IEnumerable<TodoItem>> GetAllItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem?> GetById(int id)
        {
            return await _context.TodoItems.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Remove(int id)
        {
             _context.TodoItems.Remove(new TodoItem { Id = id });
        }

    }
}