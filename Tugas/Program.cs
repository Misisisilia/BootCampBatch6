using FooBar;

class Program
{
	static void Main()
	{
		Console.Write("Masukkan berapa banyak element yang akan ditampilkan: ");
		bool status = int.TryParse(Console.ReadLine(), out int num);

		if (status == false)
		{
			Console.WriteLine("Input Harus Berupa Angka");
		}
		else
		{
			Foobar.foo_bar(num);
		}
	}

}
