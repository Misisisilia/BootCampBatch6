//Enum (Bitwise Operator)
class Program
{
	
static void Main() {
	Status result = Status.NotFound & Status.OK;
	Console.WriteLine(result);
}

public enum Status{
	NotFound = 5,
	OK = 3,
	Forbidden = 2
}
}