using Microsoft.EntityFrameworkCore;
using SmartBudget.Models;
using System.Transactions;
using Transaction = SmartBudget.Models.Transaction;

namespace SmartBudget.Data
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions options):base(options)
		{
			
		}	


		public DbSet<Transaction> Transaction { get; set; }
		public DbSet<Category> Category { get; set; }



	}
}
