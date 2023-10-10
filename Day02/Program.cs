using Transportation;
class Program
{
	static void Main() 
	{
		Car toyota = new Car();
		string result = toyota.EngineRun(false);
		Console.WriteLine(result);
		// string arah = "left";
		// toyota.Move(arah);
		toyota.Move("left");
	}
}