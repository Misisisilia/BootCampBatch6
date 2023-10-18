
//String
class Program
{
	static void Main()
{
	string myString = "Hello";
	StringAppender(ref myString);
	Console.WriteLine(myString);
}

void StringAppender(ref string input)
{
	input = input + "!!!!";
}
}