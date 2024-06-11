using WebApplication2.Model;

namespace WebApplication2.Repositories.Interfaces
{
	public interface IEmployeeRepository
	{
		public Task<List<Employee>> GetAllEmployees();
	}
}
