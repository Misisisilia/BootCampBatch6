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
// Event Handler adalah metode yang terikat pada suatu peristiwa. Saat event dimunculkan, 
// kode di dalam event handler dieksekusi. Setiap event handler memiliki 2 parameter.