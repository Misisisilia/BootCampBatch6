﻿using System.Xml.Serialization;

public class Person
{
	public string? Name { get; set; }
	public int Age { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		List<Person> people = new List<Person>
		{
			new Person { Name = "Dila", Age = 24 },
			new Person { Name = "Nima", Age = 25 }
		};

		// Serialize the list
		XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
		// using (StreamWriter writer = new StreamWriter("person.xml"))
		// {
		// 	serializer.Serialize(writer, people);
		// }

		using (StreamReader reader = new StreamReader("person.xml"))
		{
			List<Person> deserializedPeople = (List<Person>)serializer.Deserialize(reader);

			Console.WriteLine(deserializedPeople.Count);
			foreach (var person in deserializedPeople)
			{
				Console.WriteLine($"Deserialized Person: {person.Name}, {person.Age}");
			}
		}
	}
}