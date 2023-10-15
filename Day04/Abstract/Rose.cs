namespace Day04.Abstract;

public class Rose : Flower
{
	// Implementasi abstract method dari flower
	public override void Sound()
	{
		Console.WriteLine($"Merahhh Meronaaa....");
	}
}