namespace DTO_example.Models
{
    public class EmployeeWithLocation
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public Location Location { get; set; } = new Location();
    }
}
