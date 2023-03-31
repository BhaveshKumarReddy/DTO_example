using AutoMapper;
using DTO_example.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTO_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesWithLocationController : ControllerBase
    {
        List<EmployeeWithLocation> employees = new() {
          new EmployeeWithLocation(){
            Id = 1,
            Name = "Bhavesh",
            Age = 20,
            Email = "b@gmail.com",
            Location = new Location()
            {
                PinCode = 1,
                City = "Chennai"
            }
          },
          new EmployeeWithLocation(){
            Id = 2,
            Name = "Kumar",
            Age = 21,
            Email = "a@gmail.com",
            Location = new Location()
            {
                PinCode = 2,
                City = "Pune"
            }
          }
        };

        private readonly IMapper _mapper;
        public EmployeesWithLocationController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<List<EmployeeWithLocationDTO>> getEmployeeNameLocation()
        {
            var emp_name_location = employees.Select(employee => _mapper.Map<EmployeeWithLocationDTO>(employee)).ToList();
            return emp_name_location;
        }


    }
}
