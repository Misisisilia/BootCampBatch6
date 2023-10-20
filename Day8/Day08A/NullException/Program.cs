//null
class Program
{
static void Main()
{
	Car car = new Car();
	Console.WriteLine(car.x);
	//car.engine.Test();
	Console.WriteLine(car.y.Length);

}

class Car {
	public Engine engine;
	public string? y;
	public int x;
}
class Engine
{
	public void Test() {
		Console.WriteLine("test");
	}
}
}
// You can define other methods, fields, classes and namespaces here