﻿﻿class Program
{
	static void Main()
	{
		string path = @"./myFile.txt";
		using(FileStream file = new FileStream(path ,FileMode.Create)) 
		{
			using(StreamWriter sw = new(file))
			{
				sw.WriteLine("Hello Misi");
			}
		}
	}
}