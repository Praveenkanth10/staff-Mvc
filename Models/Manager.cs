using System.Collections.Generic;

public class Manager : Staff
{
    public List<Project> Projects { get; set; } = new List<Project>(); // Add this property
}
