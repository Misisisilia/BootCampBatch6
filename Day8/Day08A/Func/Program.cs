//Func
class Program
{

	static void Main()
	{
		Func<int, int, int> func = Add;
		Func<string, int, bool, string> func2 = Message;
	}

	int Add(int a, int b)
	{
		return a + b;
	}
	string Message(string a, int b, bool c)
	{
		return "test";
	}
}