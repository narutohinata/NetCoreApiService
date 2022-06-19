using Microsoft.EntityFrameworkCore;

namespace NetFrameworkLeaner.Models
{
	public class PersonContext : DbContext
	{
		public DbSet<Person> Users { get; set; } = null!;

		public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }
	}
}

