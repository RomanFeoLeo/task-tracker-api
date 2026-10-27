using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Api.Dtos;

public class CreateTaskDto
{
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
}