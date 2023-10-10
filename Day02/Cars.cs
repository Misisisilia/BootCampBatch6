using System.Xml.Linq;

namespace Transportation;

class Cars
{
public string brand;
public string type;
public int door;

public Cars (string brand, string type, int door)

{
	this.brand = brand;
	this.type = type;
	this.door = door;
}
}