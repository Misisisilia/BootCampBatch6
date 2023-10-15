namespace Day04.Interface;

public class HumanSudahPunyaAnak : IPunyaAnak
{
	public void TanggalLahir()
	{
		Console.WriteLine($"9 Oktober 2000");
	}
	public void BayarListrik()
	{
		Console.WriteLine($"Bayar Listrik 1 Juta");
	}


	public void Kerja()
	{
		Console.WriteLine($"Kerja di Formulatrix jadi Software Developer");
	}

	public void Kuliah()
	{
		Console.WriteLine($"Kuliah di UGM");
	}

	public void PunyaAnak()
	{
		Console.WriteLine($"Anak OK");
	}

	public bool SudahPunyaAnak(int anak)
	{
		return anak > 1;
	}

	void IPermintaanAnak.BeliBaju()
	{
		Console.WriteLine($"Belanja OK");
	}

	void IPermintaanAnak.UangSPP()
	{
		Console.WriteLine($"Uang SPP 300 OK");
	}
}