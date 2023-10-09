using Tutorial;
class Program
{
	 static void Main (string[]args)
	
	{
		Cat oyen = new Cat();
		
		oyen.Name = "Oyen";
		oyen.Colour = "Orange";
		oyen.Leg = 6;
		oyen.IsTailLong = true;
		oyen.Weight = 20;
		oyen.Height = 20;
		
		Console.Write("Name : ");
		Console.WriteLine (oyen.Name);
		Console.Write("Colour : ");
		Console.WriteLine (oyen.Colour);
		Console.Write("Leg : ");
		Console.WriteLine (oyen.Leg);
		Console.Write("Is Tail Long : ");
		Console.WriteLine (oyen.IsTailLong);
		Console.Write("Weight : ");
		Console.WriteLine (oyen.Weight);
		Console.Write("Height : ");
		Console.WriteLine (oyen.Height);
		
		oyen.Jump ();
		
		Console.WriteLine();
		
		Cat Bambang = new Cat ();
		
		Bambang.Name = "Bambang";
		Bambang.Colour = "White";
		Bambang.Leg = 5;
		Bambang.IsTailLong = false;
		Bambang.Weight = 28;
		Bambang.Height = 37;
		
		Console.Write("Name : ");
		Console.WriteLine (Bambang.Name);
		Console.Write("Colour : ");
		Console.WriteLine (Bambang.Colour);
		Console.Write("Leg : ");
		Console.WriteLine (Bambang.Leg);
		Console.Write("Is Tail Long : ");
		Console.WriteLine (Bambang.IsTailLong);
		Console.Write("Weight : ");
		Console.WriteLine (Bambang.Weight);
		Console.Write("Height : ");
		Console.WriteLine (Bambang.Height);
		
		Bambang.Run();
		Console.ReadLine();
	}
}