﻿﻿class Program 
{
	static void Main() 
	{
		string result = String.Empty;
		int iteration = 100;
		for(int i = 0; i < iteration; i++) 
		{
			result += "Misi ";
			result += "Cantik";
		}
		Console.WriteLine(result);
	}
}