namespace DTO_example.Models
{
    public class EmployeeWithLocationDTO
    {
        public string Name { get; set; } = string.Empty;
        public LocationDTO Location { get; set; } = new LocationDTO();
    }
}
