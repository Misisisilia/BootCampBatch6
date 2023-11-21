using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database;

public class Product
{
	public Guid ProductId { get; set; }
	public string ProductName { get; set; } = null!;
	public string? Description { get; set; }
	public Category Category { get; set; } = null!;
	public Guid CategoryId{ get; set; }
}
// 	public int ProductId {get ; set;}
// 	// [Required]
// 	// [StringLength(40)]
// 	public string ProductName {get; set;}=null!;
// 	// [Column("UnitPrice", TypeName ="money")]
// 	public decimal? cost	{get; set;}
// 	// [Column("UnitInStock")]
// 	public short stock {get; set;}
// 	public bool Discontinued{get;  set;}
// 		// these two define the foreign key relationship
// 		// to the Categories table
// 		public int CategoryId { get; set; }
// 		public  Category Category { get; set; } = null!;
// }
