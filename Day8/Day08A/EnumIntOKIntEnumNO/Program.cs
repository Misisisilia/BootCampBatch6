class Program
{
static void Main()
{
	//Enum -> int
	int numberOfDay = (int)Days.Saturday;
	Console.WriteLine(numberOfDay);
	
	//int -> enum (undertemine)
	Days day = (Days)15;
	Console.WriteLine(day);
}

public enum Days
{
	Monday = 1,
	Tuesday = 7,
	Wednesday,
	Thursday,
	Friday = 11,
	Saturday =12,
	Sunday = 13
}
}