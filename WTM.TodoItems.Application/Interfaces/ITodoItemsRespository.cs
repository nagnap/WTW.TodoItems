using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTM.TodoItems.Domain;

namespace WTM.TodoItems.Application.Interfaces
{
    public interface ITodoItemsRespository
    {
        Task<int> Add(TodoItem newItem);

        Task<IEnumerable<TodoItem>> GetAllItems();

        Task<TodoItem?> GetById(int id);

        void Remove(int id);
    }
}
