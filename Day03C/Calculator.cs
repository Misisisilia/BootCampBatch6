class Calculator 
 {
	
	public void Add(int a, int b) {
		Console.WriteLine("Hasil Penjumlahan a+b adalah " + (a+b));
	}
	
	public void Add (int a, int b, int c){
		Console.WriteLine("Hasil Perhitungan a+b+c adalah " + (a*b+c));
	}

	public string Add (string a, string b, string c)
	{
			return a+b;
	}


}