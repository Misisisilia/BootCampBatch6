//Parsing with TryParse
class Program
{
	static void Main()
{
	string myString = "351";
	bool statusParsing = int.TryParse(myString, out int result);
	Console.WriteLine(result);
	Console.WriteLine(statusParsing);
}
}