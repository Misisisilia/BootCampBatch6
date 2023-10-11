
class Duck : Animal

{
	public new void MakeSound()
	
	{
		Console.WriteLine("wkwkwk");
	}
}
class Dog : Animal 
{ 

}

class Frog : Animal

{
	public override void MakeSound()
	{
Console.WriteLine("kUKURKUK")    ;
}
}
class Animal 
{
	public virtual void MakeSound()
	
	{
		Console.WriteLine("Bersuara");
	}
}