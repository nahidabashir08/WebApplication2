using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Controllers;
using WebApplication2.Model;
using WebApplication2.Repositories.Interfaces;
using Xunit;

namespace ClassLibrary1.ControllerTest
{
	public class EmployeeControllerTest
	{
		public readonly Mock<IEmployeeRepository> empRepositoryMock = new();


		[Fact]
		public async Task GetAllEmployeeAsync_WhenEmployeeList()
		{
			//Arrange
			var expectedEmployees = new List<Employee>() { new Employee { Id = 1, EmpName = "Nahida", Designation = "Software Developer" } };
			this.empRepositoryMock.Setup(repo => repo.GetAllEmployees())
				.Returns(Task.FromResult(expectedEmployees));
			var controller = new EmployeeController(this.empRepositoryMock.Object);

			//Act
			var actionResult = await controller.GetAllEmployeeAsyn();

			//Assert
			var okObjectResult = Assert.IsType<OkObjectResult>(actionResult);
			Assert.Equal((int)System.Net.HttpStatusCode.OK, okObjectResult.StatusCode.GetValueOrDefault());
		}
	}
}
