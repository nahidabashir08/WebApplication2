using Microsoft.EntityFrameworkCore;
using WebApplication2.Model;

namespace WebApplication2.Data
{
	public class EmpDbContext:DbContext
	{
		public EmpDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
		
		public DbSet<Employee> Employees { get; set; }

	}
}
