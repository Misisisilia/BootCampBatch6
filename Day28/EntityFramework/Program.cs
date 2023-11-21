﻿using EntityFramework;

class MainProgram 
{
	static async Task Main ()
	{
		using (Northwind db= new Northwind())
		{
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
			// 		CategoryName = "Coffee",
			// 		Description = "Ini coffee",
			// 	},
			// 	new Category()
			// 	{
			// 		CategoryName = "Yusuf",
			// 		Description = "Ini Yusuf",
			// 	});
			// await db.SaveChangesAsync();

			// var myCat = await db.Categories?.FirstOrDefaultAsync(c => c.CategoryName.Contains("Coffee"));
			// Console.WriteLine(myCat?.CategoryName);
			// Console.WriteLine(myCat?.Description);
		}
		}
	}
}
