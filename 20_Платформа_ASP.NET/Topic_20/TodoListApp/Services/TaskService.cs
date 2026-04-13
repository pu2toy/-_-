using TodoListApp.Models;
using TodoListApp.Data;

namespace TodoListApp.Services
{
    public class TaskService : ITaskService
    {
        public List<TodoItem> GetAll()
        {
            return TodoRepository.Items;
        }

        public void Add(TodoItem item)
        {
            item.Id = TodoRepository.Items.Count + 1;
            TodoRepository.Items.Add(item);
        }

        public void Complete(int id)
        {
            var item = TodoRepository.Items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.IsCompleted = true;
            }
        }
    }
}
