namespace Day36_DatabaseSqlite;
using Microsoft.EntityFrameworkCore;
public class Nortwind : DbContext
{
	public DbSet<Catergory>? catergories;
	public DbSet<Product>? products;
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite(@"Data Source= ./Nortwind.db");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Catergory>()
						   .Property(e => e.CatergoryName)
						   .IsRequired()
						   .HasMaxLength(15);
		modelBuilder.Entity<Catergory>()
						.Property(c => c.CatergoryId)
						.HasMaxLength(6);

		if (Database.ProviderName?.Contains("Sqlite") ?? false)

		{
			modelBuilder.Entity<Product>()
			.Property(p => p.Cost)
			.HasConversion<double>();
		}
	}
}
