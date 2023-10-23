class Program
{
	
static void Main() {
	//Car cara = new Car(3);
	//Car carb = cara;
	//bool result = cara == carb;
	//result.Dump();

	Fruit Fruita = new Fruit(3);
	Fruit Fruitb = new Fruit(3);
	Wind w = new Wind();
	bool result = Fruita.Equals(Fruitb);
	Console.WriteLine(result);
}
class Wind {}
class Fruit {
	public int FruitId {get; private set;}
	public Fruit(int id) {
		FruitId = id;
	}
	public override bool Equals(object x) {
		if(x is Fruit w) 
		{
			var Fruit = x as Fruit;
			return FruitId == w.FruitId;
		}
		return false;
	}
	
}
}