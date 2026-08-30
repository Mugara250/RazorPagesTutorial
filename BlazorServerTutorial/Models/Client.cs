using System.ComponentModel.DataAnnotations;

namespace BlazorServerTutorial.Models;

public class Client
{
    public int Id { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string Name { get; set; } = "";
    [Required]
    [EmailAddress(ErrorMessage = "You must provide a valid email address")]
    public string Email { get; set; } = "";
    [Required]
    [StringLength(50, ErrorMessage = "Company name must not exceed 50 characters")]
    public string Company { get; set; } = "";
    public bool IsActive { get; set; }
    
}