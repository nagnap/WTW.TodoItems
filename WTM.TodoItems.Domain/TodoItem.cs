using System.ComponentModel.DataAnnotations;

namespace WTM.TodoItems.Domain
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public TodoItemStatus Status { get; set; }

    }

    public enum TodoItemStatus
    {
        New,
        InProgress,
        Complete
    }

}