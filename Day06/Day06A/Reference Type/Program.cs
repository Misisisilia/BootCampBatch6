class Program
{
	static void Main()
	{
//Reference Type, why dont need Ref
	Car car = new Car(2000); //Reference Type
	MultiplyByTwoCar(car);
	Console.WriteLine(car);// 4000
}

void MultiplyByTwoCar(Car input)
{
	input.price = input.price * 2;s
}
class Car {
	public int price;
	public Car(int value)
	{
		price = value;
	}
}
	}


