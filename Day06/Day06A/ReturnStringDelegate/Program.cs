public delegate string MyDelegate(); //wadah dari method

class Program
{
	static void Main()
	{
		MyDelegate myDelegate = Printer;
		myDelegate += Layangan;

		string result = myDelegate(); //Invoke
		Console.WriteLine(result);
	}
	static string Printer()
	{
		return "Printer";
	}
	static string Layangan()
	{
		return "Layangan";
	}
}