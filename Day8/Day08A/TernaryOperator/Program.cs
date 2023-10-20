//ternary operator (if else)
class Program
{

static void Main()
{
	bool status = 10 > 0 ? true : false;
	string result = 10 > 0 ? "yes" : "no";
}

bool Checker(int a, int b) {
	return a > b;
}
string CheckerTernary(int a, int b)
{
	return a > b ? "bigger" : "smaller";
}
}