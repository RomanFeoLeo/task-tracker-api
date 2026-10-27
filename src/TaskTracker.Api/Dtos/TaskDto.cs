using TaskTracker.Api.Models;

namespace TaskTracker.Api.Dtos;

public class TaskDto
{
    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public TaskItemStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DueDate { get; set; }
}