using Microsoft.AspNetCore.Mvc;
using TodoListApp.Data;
using TodoListApp.Models;

namespace TodoListApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index(string status)
        {
            var items = TodoRepository.Items;

            if (status == "completed")
                items = items.Where(x => x.IsCompleted).ToList();
            else if (status == "active")
                items = items.Where(x => !x.IsCompleted).ToList();

            return View(items);
        }

        [HttpPost]
        public IActionResult Add(string title)
        {
            var newItem = new TodoItem
            {
                Id = TodoRepository.Items.Count + 1,
                Title = title,
                IsCompleted = false
            };

            TodoRepository.Items.Add(newItem);
            return RedirectToAction("Index");
        }

        public IActionResult Complete(int id)
        {
            var item = TodoRepository.Items.FirstOrDefault(x => x.Id == id);
            if (item != null)
                item.IsCompleted = true;

            return RedirectToAction("Index");
        }
    }
}
