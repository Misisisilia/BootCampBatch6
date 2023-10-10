using System.Xml.Linq;

namespace Transportation;

class Car
{
public string brand;
public string type;
public int door;
// public Car()

// {
// 	brand = "Honda";
// 	type = "Karimun";
// 	door = 4;
// }



public Car (string brand, string type, int door)

{
	this.brand = brand;
	this.type = type;
	this.door = door;
}
}
