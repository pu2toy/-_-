using TodoListApp.Models;

namespace TodoListApp.Services
{
    public interface ITaskService
    {
        List<TodoItem> GetAll();
        void Add(TodoItem item);
        void Complete(int id);
    }
}
