class Program
{
static void Main() {
	List <int> myInt = new List<int>{2,4,6};
	var enumerable = myInt.GetEnumerator();
	
	enumerable.MoveNext();
	int result = enumerable.Current;
	Console.WriteLine(result);
	foreach(var x in myInt)
	{
		Console.WriteLine(x);
	}
}

}