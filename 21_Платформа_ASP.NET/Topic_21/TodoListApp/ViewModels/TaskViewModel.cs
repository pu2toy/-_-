using System.ComponentModel.DataAnnotations;

namespace TodoListApp.ViewModels
{
    public class TaskViewModel
    {
        [Required(ErrorMessage = "Введите описание")]
        public required string Description { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Укажите дату")]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
