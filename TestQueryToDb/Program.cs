using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TestQueryToDb.Context;

namespace TestQueryToDb
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string? CnnStr = "Data Source=DESKTOP-NGMQCRU\\SQLEXPRESS;Initial Catalog=no;Integrated Security=True;TrustServerCertificate=True";
			using NoDbContext _db = new NoDbContext(
										new DbContextOptionsBuilder<NoDbContext>().UseSqlServer(CnnStr).Options);

			Stopwatch sw = Stopwatch.StartNew();
			
			sw.Start();	
			var query = _db.n03
						.Where(item => item.Nb == "0966");
			sw.Stop();
			Console.WriteLine($"Затраченное время на запрос: {sw.ElapsedMilliseconds} ms");
			
			foreach (var item in query) 
			{
				Console.WriteLine($"{item.Nb}	{item.Ps}");
			}

			Console.ReadKey();	
		}
	}
}