//Action
class Program
{

static void Main()
{
	Action<string> act = null;
	act?.Invoke("hello"); //without ? will be exception
	
}

void Printer(string message)
{
	Console.WriteLine(message);
}
void Update(string update)
{
	Console.WriteLine(update);
}
}
