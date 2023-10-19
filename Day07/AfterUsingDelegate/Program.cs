//AFTER using Delegate
class Program
{
static void Main()
	{
public delegate void MyDelegate(string message);

public class MyDelegate 
{
	private MyDelegate _myDel;
	public void AddSubscriber(MyDelegate add) {
		_myDel += add;
	}
	public void EndGame() {
		_myDel?.Invoke("data");
	}
}
	}
}