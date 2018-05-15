using System.Data.Entity;
using ef.Models;

namespace ef.Data
{
	public class NerdDinnerContext : DbContext
	{
		public NerdDinnerContext(): base("ef") { }

		public DbSet<Dinner> Dinners { get; set; }
	}
}