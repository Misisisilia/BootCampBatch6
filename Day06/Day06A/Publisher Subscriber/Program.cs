public delegate void Notify(string message);
class Program {
	static void Main()
	{
		Publisher pub = new Publisher();
		Subscriber sub1 = new Subscriber();
		sub1.SubscribeTo(pub);
		pub.UploadVideo();
		
		pub.ClearAllSubscriber();
		pub.UploadVideo();
	}
}
class Publisher
{
	private Notify subscriber;

	public void UploadVideo()
	{
		Console.WriteLine("Uploading Video...");
		Console.WriteLine("Finished");
		NotifyMySubscriber("Check my video");
	}
	public void NotifyMySubscriber(string message)
	{
		subscriber?.Invoke(message);
	}
	public void AddNewSubscriber(Notify newSubscriber) {
		subscriber += newSubscriber;
	}
	public void ClearAllSubscriber() {
		subscriber = null;
	}
}
class Subscriber
{
	public void Notification(string message)
	{
		Console.WriteLine($"Subscriber 1 got notif : {message}");
	}
	public void SubscribeTo(Publisher pub) {
		pub.AddNewSubscriber(Notification);
	}
}