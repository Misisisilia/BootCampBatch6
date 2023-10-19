//+=
public delegate string MyDelegate();
void Main()
{
	MyDelegate mydel = Message;
	MyDelegate mydel2 = PrintOut;
	MyDelegate result = mydel + mydel2;

	MyDelegate mydelll = Message;
	mydelll += PrintOut;
}

string Message()
{
	return "message";
}
string PrintOut()
{
	return "printout";
}

// You can define other methods, fields, classes and namespaces here