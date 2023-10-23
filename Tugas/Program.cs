using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
	class Program
		 {
        static void Main()
        {
            Console.WriteLine("Masukkan berapa banyak element yang akan ditampilkan:");
            var element = Console.ReadLine();
            foobar(int.Parse(element));
            Console.ReadLine();
        }
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

		public static void foobar(int element)
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
}