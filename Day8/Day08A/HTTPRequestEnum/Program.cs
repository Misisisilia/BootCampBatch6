//HTTPRequest enum
public enum HTTPRequest {
	NotFound = 404,
	OK = 200,
	Forbidden = 403
}
class Program
{

static void Main()
{
	WebAccess.ContinueAccess(HTTPRequest.Forbidden);
}

class WebAccess {
	public static void ContinueAccess(HTTPRequest status) {
		if (status == HTTPRequest.NotFound) {
			Console.WriteLine((int)status);
		}
		else if (status == HTTPRequest.OK) {
			Console.WriteLine((int)status);
		}
		else
		{
			Console.WriteLine((int)status);
		}
	}
}
}