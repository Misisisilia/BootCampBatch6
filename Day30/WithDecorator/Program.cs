using System;

// Komponen dasar
interface ICoffee
{
	void MakeCoffee();
}

// Komponen konkret
class SimpleCoffee : ICoffee
{
	public void MakeCoffee()
	{
		Console.WriteLine("Membuat kopi dasar.");
	}
}

// Dekorator abstrak
abstract class CoffeeDecorator : ICoffee
{
	protected ICoffee coffee;

	public CoffeeDecorator(ICoffee coffee)
	{
		this.coffee = coffee;
	}

	public virtual void MakeCoffee()
	{
		coffee.MakeCoffee();
	}
}

// Dekorator konkret
class MilkDecorator : CoffeeDecorator
{
	public MilkDecorator(ICoffee coffee) : base(coffee)
	{
	}

	public override void MakeCoffee()
	{
		base.MakeCoffee();
		AddMilk();
	}

	private void AddMilk()
	{
		Console.WriteLine("Tambahkan susu.");
	}
}

// Dekorator konkret
class SugarDecorator : CoffeeDecorator
{
	public SugarDecorator(ICoffee coffee) : base(coffee)
	{
	}

	public override void MakeCoffee()
	{
		base.MakeCoffee();
		AddSugar();
	}

	private void AddSugar()
	{
		Console.WriteLine("Tambahkan gula.");
	}
}

// Penggunaan dengan decorator
class Program
{
	static void Main()
	{
		// Penggunaan tanpa dekorator
		ICoffee simpleCoffee = new SimpleCoffee();
		simpleCoffee.MakeCoffee();

		Console.WriteLine();

		// Penggunaan dengan dekorator Milk
		ICoffee milkCoffee = new MilkDecorator(new SimpleCoffee());
		milkCoffee.MakeCoffee();

		Console.WriteLine();

		// Penggunaan dengan dekorator Sugar
		ICoffee sugarCoffee = new SugarDecorator(new SimpleCoffee());
		sugarCoffee.MakeCoffee();

		Console.WriteLine();

		// Penggunaan dengan dekorator Milk dan Sugar
		ICoffee milkAndSugarCoffee = new SugarDecorator(new MilkDecorator(new SimpleCoffee()));
		milkAndSugarCoffee.MakeCoffee();
	}
}
