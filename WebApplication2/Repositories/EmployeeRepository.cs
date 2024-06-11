using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Model;
using WebApplication2.Repositories.Interfaces;

namespace WebApplication2.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly EmpDbContext empDbContext;
		public EmployeeRepository(EmpDbContext _empDbContext)
		{
			empDbContext= _empDbContext;
		}
		public async Task<List<Employee>> GetAllEmployees()
		{
			return await empDbContext.Employees.ToListAsync();
		}
	}
}
