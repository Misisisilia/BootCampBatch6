using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework;

public class Product
{
	public int ProductId {get ; set;}
	[Required]
	[StringLength(40)]
	public string ProductName {get; set;}=null!;
	[Column("UnitPrice", TypeName ="money")]
	public decimal? cost	{get; set;}
	[Column("UnitInStock")]
	public short stock {get; set;}
	public bool Discontinued{get;  set;}
		// these two define the foreign key relationship
		// to the Categories table
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; } = null!;
}
