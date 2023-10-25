//Stack
class Program
{
	static void Main()
	{
		Stack<int> myStack = new();
		myStack.Push(2);
		myStack.Push(4);
		myStack.Push(6);
		myStack.Push(8);

		//foreach(var e in myStack) {
		//	Console.WriteLine(e)();
		//}
		//var enumerator = myStack.GetEnumerator();
		//enumerator.MoveNext();
		//Console.WriteLine("test");
		//Console.WriteLine(enumerator.Current);

		Console.WriteLine(myStack.Pop());
		Console.WriteLine(myStack.Pop());
		Console.WriteLine(myStack.Peek());
		Console.WriteLine(myStack.Peek());
		// Console.WriteLine(myStack.Pop);
		// Console.WriteLine(myStack.Pop);
		// Console.WriteLine(myStack.Pop); //Exception, data habis
	}

}