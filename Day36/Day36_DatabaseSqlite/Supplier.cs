using System.ComponentModel.DataAnnotations;

namespace Day36_DatabaseSqlite;

public class Supplier
{
	public int SupplierId { get; set; }
	
	[Required]
	[StringLength(40)]
	public string? CompanyName { get; set; }
}
