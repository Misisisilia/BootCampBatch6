using Microsoft.EntityFrameworkCore;
namespace EntityFramework;

public class Northwind : DbContext
{
	public DbSet<Category>? Categories{get;set;}
	public DbSet<Product>? Products {get;set;}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Filname=./Northwind.db");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>(categ =>
		
		{
			categ.HasKey(categ=>categ.CategoryId);
			categ.Property(categ=>categ.CategoryName).IsRequired().HasMaxLength(40);
			categ.Property(categ=>categ.Description).HasColumnType("NTEXT");
			categ.HasMany(categ=>categ.Products).WithOne(prod =>prod.Category);
		});
		modelBuilder.Entity<Product> (prod =>
		{
			prod.Property(prod=>prod.ProductName).IsRequired().HasMaxLength(40);
			prod.Property(prod=>prod.cost).HasColumnName("UnitPrice").HasColumnType("money");
		});
		modelBuilder.Entity<OrderDetail>(order=>
		
		{
			order.HasKey(o=>new{o.OrderId, o.ProductId});
		}
		);
	}
}
