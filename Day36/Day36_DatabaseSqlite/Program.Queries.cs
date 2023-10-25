namespace Day36_DatabaseSqlite;
using Microsoft.EntityFrameworkCore;
public partial class Program
{
	static void QuresyingCategories()
	
	{
		using(Nortwind db = new())
		
		{
			SectionTitle("Querying Categories and Products");

			IQueryable<Catergory>? categories = db.catergories?
												.Include(c => c.Products); //Eager loading

			if ((categories == null) || (!categories.Any()))
			{
				Fail("No Categories Found");
				return;
			}
			Info($"ToQueryString: {categories.ToQueryString()}"); //Print SQL command
			foreach (Catergory? c in categories)
			{
				Printer($"Category: {c.CatergoryName} has {c.Products.Count} products.");
			}
		}
	}

	static void FilteredIncludes()
	{
		using (Nortwind db = new())
		{
			SectionTitle("Filtered Includes");
			string? input;
			int stock;

			do
			{
				Printer("Enter a product stock level: ");
				input = GetInput();
			}
			while (!int.TryParse(input, out stock));

			IQueryable<Catergory>? categories = db.catergories?
												.Include(c => c.Products.Where(p => p.Stock >= stock));

			if ((categories == null) || (!categories.Any()))
			{
				Fail("No Categories Found");
				return;
			}
			Info($"ToQueryString: {categories.ToQueryString()}");
			foreach (Catergory? c in categories)
			{
				Info($"Category: {c.CatergoryName} has {c.Products.Count} products with minimum {stock}.");

				foreach (Product? p in c.Products)
				{
					Printer($"\t{p.ProductName} has {p.Stock} in stock.");
				}
			}
		}
	}

	static void QueryingProducts()
	{
		using (Nortwind db = new())
		{
			SectionTitle("Products that cost more than a price, highest at top.");

			string? input;
			decimal price;
			do
			{
				Printer("Enter a product price: ");
				input = GetInput();
			} while (!decimal.TryParse(input, out price));

			var products = db.products?
							.Where(product => product.Cost > price)
							.OrderByDescending(product => product.Cost);

			if ((products is null) || (!products.Any()))
			{
				Fail("No products found.");
				return;
			}
			Info($"ToQueryString: {products.ToQueryString()}");
			foreach (Product p in products)
			{
				Printer($"{p.ProductId}: {p.ProductName} costs {p.Cost:$#,##0.00} and has {p.Stock} in stock.");
			}
		}
	}
}
