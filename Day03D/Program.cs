class Program

{
	static void Main()
	{
		Frog f = new Frog();
	f.MakeSound();
	Animal parent = f;
		parent.MakeSound(); 
	
	Duck d = new Duck();
	d.MakeSound();
	Animal parent2 = d;
		parent2.MakeSound(); 
	
	
	Dog dg = new Dog(); //Idem
		dg.MakeSound(); //Make Sound
		Animal parent3 = dg;
		parent3.MakeSound(); 
	
	}
	
}