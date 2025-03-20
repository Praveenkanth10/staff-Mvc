public class Staff
{
    public int Id { get; set; }  // Ensure this primary key is defined
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; } // "Employee" or "Manager"
}
