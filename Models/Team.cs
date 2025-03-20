using StaffManagement.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Staff> Members { get; set; }
    public int ManagerId { get; set; }
    public Manager Manager { get; set; }
}
