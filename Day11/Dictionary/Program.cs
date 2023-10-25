//Dictionary
class Program 
{
static void Main()
{
	Dictionary<int,string> myDict = new();
	myDict.Add(3,"foo");
	myDict.Add(5,"bar");
	//myDict.Add(3,"fizz"); Key must be unique
	myDict.Add(7,"foo"); //Value bebas
	foreach(KeyValuePair<int,string> e in myDict) {
		Console.WriteLine($"{e.Key} {e.Value}");
	}
	string myValue = myDict[3];
	Console.WriteLine(myValue);
	
	string valueForSearch = "foo";
	int keyResult = 0;
	foreach(var e in myDict) {
		if(e.Value == valueForSearch) {
			keyResult = e.Key;
			break;
		}
	}
	Console.WriteLine(keyResult);
	//Contains -> KeyValuePair
	//ContainsKey() -> value key
	//ContainsValue() -> value of value
	KeyValuePair<int,string> keysvalue = new(3,"foo");
	bool checkKey = myDict.Contains(keysvalue);
	Console.WriteLine(checkKey);

	myDict[3] = "buzz"; //Change Value
	
	int keyAdd = 3;
	string valueAdd = "Sisil";
	myDict.TryAdd(1, "Sisil"); //TryAdd 
	foreach (KeyValuePair<int, string> e in myDict)
	{
		Console.WriteLine($"{e.Key} {e.Value}");
	}
}
}