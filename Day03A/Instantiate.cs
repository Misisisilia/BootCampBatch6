//class instantiate
class instantiate {
	static void Main() {
		Cat cat = new Cat();
		Cat cat1 = new();
		var cat2 = new Cat();
		//var cat3 = new(); <- Error
	}
}

class Cat {
	public string name;
	private int age;
	
	public void Jump() {
		// "Jump".Dump();
	}
	protected void Eat() {
		// "Eat".Dump();
	}
}