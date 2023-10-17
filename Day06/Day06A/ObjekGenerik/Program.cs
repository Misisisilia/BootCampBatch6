//Object -> Generic
class Program
{
	static void Main()
{
	MyCollection<string> myStringCollection = new();
	myStringCollection.SetValue(0, "hello");
	myStringCollection.SetValue(1, "world");
	
	Console.WriteLine(myStringCollection.GetValue(0));
}

class MyCollection<T>
{
	private T[] collection = new T[100];
	public T GetValue(int index) {
		if(index < collection.Length-1) {
			return collection[index];
		}
		throw new IndexOutOfRangeException("Not found data");
	}
	public bool SetValue(int index, T data) {
		collection[index] = data;
		return true;
	}
}
}