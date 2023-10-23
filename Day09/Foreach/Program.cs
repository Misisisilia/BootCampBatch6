//Foreach
class Program
{
	
static void Main() {
	int[] myArray = {1,2,3,4,5};
	foreach(var v in myArray) {
		Console.WriteLine(v);
	}
	
	List<string> myList = new List<string>() {"a","b","c"};
	foreach(string s in myList) {
		Console.WriteLine(s);
	}
	
	List<Car> myCar = new List<Car>() {
		new Car("Hello"),
		new Car("TEST"),
		new Car("toyota")
	};
	foreach(Car c in myCar) {
		Console.WriteLine(c.brand);
	}
}

class Car { 
	public string brand;
	public Car(string brand) 
	{
		this.brand = brand;
	}
}
}