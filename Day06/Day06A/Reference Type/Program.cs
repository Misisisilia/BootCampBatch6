class Program
{
	static void Main()
	{
		// Console.WriteLine("");
		// string input = Console.ReadLine();
		// int.TryParse(input,out int result);
		// int result= 4000;
	
	
//Reference Type, why dont need Ref
	Car car = new Car(result); //Reference Type
	MultiplyByTwoCar(car);
	Console.WriteLine(car);// 4000
}

void MultiplyByTwoCar(Car input)
{
	input.price = input.price * 2;
}
class Car 
{
	public int price;
	public Car(int value)
	{
		price = value;
	}
}
	}


