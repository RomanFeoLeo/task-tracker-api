using System.ComponentModel.DataAnnotations;
using TaskTracker.Api.Models;

namespace TaskTracker.Api.Dtos;

public class UpdateTaskDto
{
    [Required]
    [MaxLength(200)]
    public string Title { get;; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
    public TaskItemStatus Status { get; set; }
}