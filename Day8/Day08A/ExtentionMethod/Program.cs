//Extension Method
class Program{
static void Main()
{
	"Hello".Cetak();
	3.Cetak();
	bool lebihBesar = 3.Dibandingkan(6);
	lebihBesar.Cetak();
}


public static class MyCetak {
	public static void Cetak(this object input) {
		Console.WriteLine(input);
	}
	public static bool Dibandingkan(this int a, int b) {
		return a > b;
	}
}

}