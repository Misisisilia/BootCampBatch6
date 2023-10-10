namespace Transportation;

public class Car
{
	public string colour;
	public int door;
	public int wheel;
	public string engine;
	public int seat;
	
	public string EngineRun(bool status) 
	{
		if(status) 
		{
			return "Engine Run";
		}
		else 
		{
			return "Engine Not Run";
		}
	}
	public void Move(string direction) 
	{
		//String Interpolation
		Console.WriteLine(direction);
		Console.WriteLine("Car move to " + direction + " now");
		Console.WriteLine($"Car move to {direction} now");
		Console.WriteLine($"\t Car move \n to {direction} now");
	}
	
}
