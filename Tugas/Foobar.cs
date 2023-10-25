namespace FooBar;

class Foobar
{
	static Dictionary<int,string> myDict = new()
	{
		{3, "foo"},
		{5, "bar"},
	};

	public static void foo_bar(int element)
	{
		string result = string.Empty;
		for (var i = 1; i <= element; i++)
		{
			foreach(var e in myDict)
			{
				if (i%e.Key == 0 )
				{
					Console.Write(e.Value);
				}
				else
				{
					Console.Write(i);
				}
				Console.Write(", ");
			}
			
			// var dapatDibagi = false;
			// if (i%3 == 0 && i%5 == 0)
			
			// {
			// 	Console.Write("foobar");
			// }
			// else if ( i%3 == 0)
			// {
			// 	Console.Write("foo");
			// 	// dapatDibagi = true;
			// }


			// else if ( i%5 == 0)
			// {
			// 	Console.Write("bar");
			// 	// dapatDibagi = true;
			// }

			// // if (dapatDibagi)
			// // 	Console.WriteLine();
			// else
			// {
			// 	Console.Write(i);
			// }
			// 	Console.Write(", ");
		}
	}

}
