namespace Day04.Abstract;

abstract public class Flower
{
	public int Name { get; set; }
	abstract public void Sound();
	public void Run()
	{
		Console.WriteLine($"Flower Is Beautifull...");
		
	}
}