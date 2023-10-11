//ReadOnly
class ReadOnly {
	static void Main(){
		Car car = new Car(1000);
		// car.price.Dump();
		//car.price = 3; readonly
	}
}
class Cars {
	public readonly int price;
	public Cars(int price) {
		this.price = price;
	}
	
	//public void SetPrice(int num) {
	//	price = num;
	//}
}