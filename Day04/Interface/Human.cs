namespace Day04.Interface;

public class Human : IPermintaanOrtu
{
	public void Kerja()
	{
		Console.WriteLine($"Kerja di Formulatrix");
	}
	
	public void Kuliah()
	{
		Console.WriteLine($"Kuliah di UKSW dooonngg");
	}
	
	public void PunyaAnak()
	{
		Console.WriteLine($"Punya Anak OKKK");
	}
	
	public bool SudahPunyaAnak(int anak)
	{
		return anak > 0;
	}
	public void MainGame()
	{
		Console.WriteLine($"Main Game Gassss");
	}

}