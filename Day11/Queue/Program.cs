//Stack
class Program
{
	static void Main()
	{
		Queue<int> myQueue = new();
		myQueue.Enqueue(3);
		myQueue.Enqueue(5);
		myQueue.Enqueue(7);
		myQueue.Enqueue(9);

		//foreach(var e in myStack) {
		//	Console.WriteLine(e)();
		//}
		//var enumerator = myStack.GetEnumerator();
		//enumerator.MoveNext();
		//Console.WriteLine("test");
		//Console.WriteLine(enumerator.Current);

		Console.WriteLine(myQueue.Dequeue());
		Console.WriteLine(myQueue.Dequeue());
		Console.WriteLine(myQueue.Peek());
		Console.WriteLine(myQueue.Peek());
		// Console.WriteLine(myQueue.Pop);
		// Console.WriteLine(myQueue.Pop);
		// Console.WriteLine(myQueue.Pop); //Exception, data habis
	}

}