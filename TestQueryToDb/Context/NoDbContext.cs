using Microsoft.EntityFrameworkCore;
using TestQueryToDb.Models.No;

namespace TestQueryToDb.Context
{
	public class NoDbContext : DbContext 
	{
		public DbSet<N03Tbl> n03 {  get; set; }	

		public NoDbContext(DbContextOptions<NoDbContext> options) : base(options) { }
	}
}
