using AutoMapper;
using DTO_example.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTO_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        List<Employee> employees = new() {
          new Employee(){
            Id = 1,
            Name = "Bhavesh",
            Age = 20,
            Email = "b@gmail.com"
          },
          new Employee(){
            Id = 2,
            Name = "Kumar",
            Age = 21,
            Email = "a@gmail.com"
          }
        };

        [HttpGet]
        public ActionResult<List<EmployeeDTO>> getEmployees()
        {
            List<EmployeeDTO> employeesDTO_list = new();

            employeesDTO_list = employees.Select(employee =>
            new EmployeeDTO()
            {
                Id = employee.Id, Name = employee.Name
            }
            ).ToList();

            return employeesDTO_list;
        }

        //using Mapper if we have more attributes

        private readonly IMapper _mapper;
        public EmployeesController(IMapper mapper) {
            _mapper = mapper;
        }


        [HttpGet("using_IMapper")]
        public ActionResult<List<EmployeeDTO>> getEmployees_usingIMapper()
        {
            List<EmployeeDTO> employeesDTO_list = new();

            employeesDTO_list = employees.Select(employee => _mapper.Map<EmployeeDTO>(employee)).ToList();

            return employeesDTO_list;

            //return employees.Select(employee => _mapper.Map<Employee, EmployeeName>(employee)).ToList();
        }

        [HttpPost]
        public ActionResult<List<Employee>> addEmployees(EmployeeDTO new_emp)
        {
            Employee employee = _mapper.Map<Employee>(new_emp);
            employees.Add(employee);
            return employees;
        }

    }
}
