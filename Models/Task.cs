using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProjectTask  // Renamed to avoid conflict with System.Threading.Tasks
{
    [Key] // Primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    public int ProjectId { get; set; }
    public Project Project { get; set; } // Navigation property
}
