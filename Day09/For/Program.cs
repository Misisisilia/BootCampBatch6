class Program
{
	
static void Main() {
{
	for(int i = 0; i< 10 ; i++) 
	{
		Printer(i);
	}
	
	int[] arrayInt = {1,2,3,4,5,6,7,8,9,10};
	foreach(int i in arrayInt) 
	{
		Printer(i);
		if(i == 3) break;
	}
}

void Printer(int i) {
	Console.WriteLine($"Print {i}");
}
}
}