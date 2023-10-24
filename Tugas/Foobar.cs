namespace FooBar;
class Foobar
{
private static int bagiTiga(int i)
		{
			var tiga = i%3;
			return tiga;
		}

		public static int bagiLima(int i)
		{
			var lima = i%5;
			return lima;
		}

		public static void foo_bar(int element)
		{
			for(var i = 1; i <= element; i++)
			{
				
				var dapatDibagi = false;

				if (bagiTiga(i) == 0)
				{
					Console.Write("foo");
					dapatDibagi = true;
				}


				if (bagiLima(i) == 0)
				{
					Console.Write("bar");
					dapatDibagi = true;
				}
					
				if (dapatDibagi)
					Console.WriteLine();
				else
					Console.WriteLine(i);
			}
		}
		
}
	