//Exception (try - catch)
class Program{
static void Main()
{
	Console.WriteLine("Start");
	int x = 0;
	try {
		Caller(ref x);
	}
	catch(Exception e) {
		Console.WriteLine(e.Message);
	}
	finally {
		Console.WriteLine("release resource");
	}
	Console.WriteLine(x);
	Console.WriteLine("Finish all task");
}

static void Caller(ref int x)
{
	Console.WriteLine("Caller called");
	int a = int.Parse(Console.ReadLine());
	int b = int.Parse(Console.ReadLine());
	x = a/b;
	Console.WriteLine("Caller finish");
}
}