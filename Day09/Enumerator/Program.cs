class Program
{
	
static void Main() {
}

class MyCollection : IEnumerator

{
	public int CurrentIndex = -1;
	public int[] myInt = new int [6];
	public object Current => myInt[CurrentIndex];
	public bool MoveNext()
	{
		if(CurrentIndex+1 < myInt.Length)
		{
			CurrentIndex++;
			return true;
		}
		else
		{
			Reset();
			return false;
		}
	}
	public void Reset()
	
	{
		CurrentIndex= -1;
	}
	
}
}