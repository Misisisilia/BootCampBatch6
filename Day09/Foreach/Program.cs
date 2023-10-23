//Foreach
class Program
{
	
static void Main() {
	int[] myArray = {2,4,6,8,10};
	foreach(var v in myArray) {
		Console.WriteLine(v);
	}
	
	List<string> myList = new List<string>() {"a","b","c"};
	foreach(string s in myList) {
		Console.WriteLine(s);
	}
	
	List<Fruit> myFruit = new List<Fruit>() {
		new Fruit("Apple"),
		new Fruit("Strawberry"),
		new Fruit("Pear")
	};
	foreach(Fruit c in myFruit) {
		Console.WriteLine(c.brand);
	}
}

class Fruit { 
	public string brand;
	public Fruit(string brand) 
	{
		this.brand = brand;
	}
}
}