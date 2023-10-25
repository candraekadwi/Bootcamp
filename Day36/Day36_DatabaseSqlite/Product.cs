using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day36_DatabaseSqlite;

public class Product
{
	[Key]
	public int ProductId{get;set;}
	[Required]
	[StringLength(40)]
	public string ProductName{get;set;}=null;
	[Column("UnitPrice", TypeName ="money")]
	public decimal? Cost{get;set;}
	[Column("UnitsInStock")]
	public short? Stock {get;set;}
	public bool Discontinued{get;set;}
	
	public int CatergoryId{get;set;}
	public virtual Catergory Catergory{get;set;} = null!;
	
}
