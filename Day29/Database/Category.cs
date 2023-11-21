using System.ComponentModel.DataAnnotations.Schema;

namespace Database;

public class Category
{
	public Guid CategoryId { get; set; }
	public string CategoryName { get; set; } = null!;
	public string? Description { get; set; }
	public ICollection<Product> Products { get; set; }
	public Category()
	{
		Products = new HashSet<Product>();
	}
}

// {
// 	public int CategoryId { get; set; }
// 	public string CategoryName { get; set; }
// 	// [Column(TypeName = "NTEXT")]
// 	public string? Description { get; set; }
// 	public ICollection<Product> Products { get; set; }
// 	public Category()

// 	{
// 		Products = new HashSet<Product>(); //MUST UNIQ
// 	}

