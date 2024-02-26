using System.ComponentModel.DataAnnotations;

namespace MyFirstAzureWebApp.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; } = string.Empty;
        [Display(Name = "Completed?")]
        public bool isCompleted { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DueDate { get; set; }

    }
}
