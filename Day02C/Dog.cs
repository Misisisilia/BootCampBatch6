namespace LivingBeing;

public class Dog : Animal

{
	public Dog (string name) : base (name)
	
	{
		Console.WriteLine("Dogg lutcuu");
	}
	
	public void Run ()
	
	{
		Console.WriteLine("Run");
	}
	public void Bark ()
	
	{
		Console.WriteLine("Bark");
	}
}