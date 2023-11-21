using Database;

class MainProgram 
{
	static async Task Main ()
	{
		using (Northwind db= new Northwind())
		
				{
			// Guid catguid = db.Categories
			// 				.FirstOrDefault(c => c.CategoryName == "Elektronik")
			// 				.CategoryId;
			// Product newProduct = new Product()
			// {
			// 	ProductId = Guid.NewGuid(),
			// 	ProductName = "Laptop Asus",
			// 	Description = "Ini Laptop Asus, kualitasnya terjamin",
			// 	CategoryId = Guid.Parse("2fc94449-99cb-481e-826f-633af1e38981"),
			// };
			// await db.Products.AddAsync(newProduct);
			// await db.SaveChangesAsync();
			{
			Console.WriteLine($"Name: {db.Database}");
			Console.WriteLine($"Database: {db.Database.ProviderName}");
			Console.WriteLine($"Database connection: {db.Database.CanConnect()}");

			// IQueryable<Category> categories = db.Categories.Where(cat => cat.CategoryId == 1)
			// 							   					.Include(cat => cat.Products);
			// foreach (Category c in categories)
			// {
			// 	Console.WriteLine(c.CategoryName);
			// 	foreach(Product p in c.Products) 
			// 	{
			// 		Console.WriteLine($"\t {p.ProductName}");
			// 	}
			// }

			// var products = db.Products.Where(p => p.CategoryId == 1);
			// foreach(Product p in products) 
			// 	{
			// 		Console.WriteLine($"\t {p.ProductName}");
			// 	}

			//Create
			// await db.Categories.AddRangeAsync(
			// 	new Category()
			// 	{
			// 		CategoryName = "Laptop Acer",
			// 		Description = "Ini Laptop terbaik",
			// 	},
			// 	new Category()
			// 	{
			// 		CategoryName = "HP Iphone 15 pro Max",
			// 		Description = "Ini HP terbaik, keluaran terbaru",
			// 	});
			// await db.SaveChangesAsync();
			
			// 	await db.Products.AddRangeAsync(
			// 	new Product()
			// 	{
			// 		ProductName = "Laptop Acer",
			// 		Description = "Ini Laptop terbaik",
			// 	},
			// 	new Product()
			// 	{
			// 		ProductName = "Laptop Acer",
			// 		Description = "Ini Laptop terbaik",
			// 	});
		
			// await db.SaveChangesAsync();
				

			// var myCat = await db.Categories?.FirstOrDefaultAsync(c => c.CategoryName.Contains("Coffee"));
			// Console.WriteLine(myCat?.CategoryName);
			// Console.WriteLine(myCat?.Description);
		}
	}
	}
}