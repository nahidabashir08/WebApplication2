using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace TestProject1.Repositories.tests
{
	public class EmployeeRepositorytest
	{
		public readonly Mock<EmpDbContext> mockEmpDbContext = new Mock<EmpDbContext>();

		[Fact]
		public async Task GetAllEmployees_ReturnsListOfEmployees()
		{

		}
	}
}
