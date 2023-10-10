namespace Transportation;

class Car


{
	public string color;
	
	public int door;
	
	public int seat;
	
	public void Move(string direction)
	{
		Console.WriteLine($"Belok {direction}");
		Console.WriteLine("");
			}
}