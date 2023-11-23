using System;

// Komponen dasar
class SimpleCoffee
{
	public void MakeCoffee()
	{
		Console.WriteLine("Membuat kopi dasar.");
	}
}

// Penggunaan tanpa decorator
class Program
{
	static void Main()
	{
		SimpleCoffee coffee = new SimpleCoffee();
		coffee.MakeCoffee();
	}
}
