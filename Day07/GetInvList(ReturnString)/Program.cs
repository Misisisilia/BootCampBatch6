//GetInvocationList (return string)
public delegate string MyDelegate();

class Program
{
	static void Main()
	{
		MyDelegate mydel = Email;
		mydel += PrintOut;

		List<string> result = new();
		Delegate[] delegateList = mydel.GetInvocationList();
		foreach (MyDelegate d in delegateList)
		{
			result.Add(d.Invoke());
			
		}
		foreach (var str in result)
		{
			Console.WriteLine(str);
		}
	}
		static string Email()
		{
			return "Selamat Pagi";
		}
		static string PrintOut()
		{
			return "Masuk";
		}
	}


// You can define other methods, fields, classes and namespaces here