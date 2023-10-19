//GetInvocationList (return string)
public delegate string MyDelegate();

class Program {
	static void Main(){

	MyDelegate mydel = Message;
	mydel += PrintOut;
	
	List<string> result = new();
	Delegate[] delegateList = mydel.GetInvocationList();
	foreach(MyDelegate d in delegateList) {
		result.Add(d.Invoke());
	
	Console.WriteLine(result;)
}

string Email() {
	return "Selamat Pagi";
}
string PrintOut() {
	return "printout";
} 
	}

}
// You can define other methods, fields, classes and namespaces here