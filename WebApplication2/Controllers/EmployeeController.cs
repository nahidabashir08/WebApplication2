using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
using WebApplication2.Repositories.Interfaces;

namespace WebApplication2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeRepository employeeRepository;
		public EmployeeController(IEmployeeRepository _employeeRepository)
		{
			employeeRepository= _employeeRepository;
		}

		public async Task<ActionResult<List<Employee>>> GetAllEmployeeAsyn()
		{
			var employees = await employeeRepository.GetAllEmployees();
			return Ok(employees);
		} 
	}
}
