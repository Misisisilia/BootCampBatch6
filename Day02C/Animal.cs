namespace LivingBeing;

public class Animal

{
	public string name;
	public int age;
	
	public Animal (string name)
	
	{
		this.name=name;
		Console.WriteLine($"Animal{name} lutcuu");
	}
	public void Eat()
	
	{
		Console.WriteLine("Eat");
	}
}