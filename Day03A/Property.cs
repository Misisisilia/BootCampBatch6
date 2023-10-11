//Property
class property {
	static void Main() {
		Car car = new Car(9);
		Console.WriteLine (car.Age);
		//car.Age = 8 //Set Accessor is Private
		
		car.Balance = 10;
		int x = car.Balance;
		// x.Dump();
	}
}