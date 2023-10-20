//Anonymous Delegate (Lambda Expression)
class Program{
static void Main()
{
	// (parameter) => (return);
	var method = (int x, int y) =>
	{
		return x + y;
	};
	
	var printer = (object x) => Console.WriteLine(x)();
	var nggangapa2in = () => Console.WriteLine("diam");
	
	printer(30);
	int result = method(3,4);
	Console.WriteLine(result)
}

int Add(int x, int y) {
	return x + y;
}

int Add2 (int x, int y) => x+y;
}