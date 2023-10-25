using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day36_DatabaseSqlite;

public class Catergory
{
	[Key]
	public int CatergoryId{get;set;}
	[Required]
	[StringLength(15)]
	public string? CatergoryName{get;set;} = null;
	[Column(TypeName ="NTEXT")]
	public string? Description {get;set;}
	
	public virtual ICollection<Product> Products{get;set;}
	
	public Catergory()
	{
		Products = new HashSet<Product>();
	}
}
