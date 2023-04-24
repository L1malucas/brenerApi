using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BrenerApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool IsComplete { get; set; }
    }
}