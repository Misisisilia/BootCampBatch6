using CarComponent;

namespace Transportation;

public class Car
{
	public Engine mesin;
	public Tire ban;
	public Lamp lampu;
	
	public Car(Engine engine, Tire tire, Lamp lamp) 
	{
		Console.WriteLine("telah menerima engine, ban, lampu");
		mesin = engine;
		ban = tire;
		lampu = lamp;
	}
	public void EngineCheck()
	{
		// Console.WriteLine(engine);
	}
	public void TireCheck() 
	{
		// Console.WriteLine(tire);
	}
}
