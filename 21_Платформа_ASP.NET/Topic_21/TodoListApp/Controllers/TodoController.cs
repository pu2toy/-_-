using Microsoft.AspNetCore.Mvc;
using TodoListApp.Data;
using TodoListApp.Models;
using TodoListApp.Services;
using TodoListApp.ViewModels;

namespace TodoListApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITaskService _taskService;

        public TodoController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index(string status)
        {
            var items = _taskService.GetAll();
            return View(items);
        }

        [HttpPost]
        public IActionResult Add(TaskViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", _taskService.GetAll());
            }

            var item = new TodoItem
            {
                Title = model.Description,
                Deadline = model.DueDate,
                IsCompleted = false
            };

            _taskService.Add(item);

            return RedirectToAction("Index");
        }

        public IActionResult Complete(int id)
        {
            _taskService.Complete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _taskService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
