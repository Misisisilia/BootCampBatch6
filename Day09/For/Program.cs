﻿class Program
{
	
static void Main() {
{
	for(int x = 0; x< 10 ; x++) 
	{
		Printer(x);
	}
	
	int[] arrayInt = {1,2,3,4,5,6,7,8,9,10};
	foreach(int x in arrayInt) 
	{
		Printer(y);
		if(x == 5) break;
	}
}

void Printer(int x) {
	Console.WriteLine($"Print {x}");
}
}
}