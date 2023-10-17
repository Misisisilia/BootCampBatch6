class Program
{
	static void Main()
{
	Car carA = new Car();
	Car carB = new Car();
	carB.PriceHandler(10);
	carA.PriceHandler(11);
	
	Console.WriteLine(carA.GetPrice());
	Console.WriteLine(carB.GetPrice());
	Console.WriteLine(Car.StaticPrice());
	
}

class Car {
	public static int StaticPrice;
	
	public void PriceHandler(int price) {
		StaticPrice = price;
	}
	public int GetPrice()
	{
		return StaticPrice;
	}
}
}