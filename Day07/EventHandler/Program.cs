//EventHandler

class Program
{
	static void Main()
	{
		Twitter pub = new Twitter("Misiiii");
		Followers sub = new Followers();
		pub.eventHandler = sub.Notification;
		pub.SendNotification();
	}
	class Twitter
	{
		private string _name;
		public EventHandler eventHandler;
		public Twitter(string name)
		{
			_name = name;
		}
		public void SendNotification()
		{
			eventHandler?.Invoke(this, EventArgs.Empty);
		}
		public override string ToString()
		{
			return _name;
		}
	}
	class Publisher
	{
		private string _name;
		public EventHandler eventHandler;
		public Publisher(string name) { _name = name; }
		public void SendNotification()
		{
			eventHandler?.Invoke(this, EventArgs.Empty);
		}
		public override string ToString()
		{
			return _name;
		}
	}
	class Followers
	{
		public void Notification(object sender, EventArgs e)
		{
			Console.WriteLine($"Called by {sender}");
		}
	}
}