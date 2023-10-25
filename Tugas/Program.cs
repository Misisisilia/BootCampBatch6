using FooBar;

	class Program
		 {
		static void Main()
		{
			Console.WriteLine("Masukkan berapa banyak element yang akan ditampilkan:");
			var element = Console.ReadLine();
			foo_bar(int.Parse(element));
			Console.ReadLine();
		}

}
