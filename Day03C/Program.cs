class Program

{
	static void Main()
	{
		Calculator C = new();
		C.Add (9,10);
		C.Add (10,10,10);
		Console.WriteLine(C.Add("3","10", "11"));
	}
}