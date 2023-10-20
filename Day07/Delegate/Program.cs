public delegate void MyDelegate(string message);
class Program {
	static void Main(){
		User pub = new User();
		Receiver notif1 = new Receiver();
	
		
		pub.AddReceiver(notif1.Notification);
		
		pub.SendMessage();
		
		pub.RemoveMessage(notif1.Notification);
		
		pub.SendMessage();
		
	}
}
class User {
	public delegate void Notify(string message);
	private Notify Receiver;
	
	public void SendMessage() {
		Console.WriteLine("Sent Message...");
		NotifyMyReceiver("Check my message");
	}
	public void NotifyMyReceiver(string message) {
		Receiver.Invoke(message);
	}
	public void AddReceiver(Notify receiv) {
		Receiver += receiv;
	}
	public void RemoveMessage(Notify receiv)
	{
		Receiver -= receiv;
	}
}
class Receiver {
	public void Notification(string message) {
		Console.WriteLine ($"Receiver 1 got notif : {message}");
	}
}
class Receiver2
{
	public void Notification(string message)
	{
		Console.WriteLine ($"Receiver 2 got notif : {message}");
	}
}
class Receiver3
{
	public void Notification(string message)
	{
		Console.WriteLine ($"Receiver 3 got notif : {message}");
	}
}