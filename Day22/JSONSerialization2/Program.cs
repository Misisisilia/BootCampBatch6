﻿using System.Text.Json;

public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
}

class Program
{
	static void Main()
	{
		List<Person> people = new List<Person>
		{
			new Person { Name = "Sali", Age = 22 },
			new Person { Name = "Visi", Age = 23 },
			new Person { Name = "Misi", Age = 23 },
		};
		string jsonString = JsonSerializer.Serialize(people);
		using (StreamWriter writer = new StreamWriter("person.json"))
		{
			writer.Write(jsonString);
		}

		string jsonFromFile;
		using (StreamReader reader = new StreamReader("person.json"))
		{
			jsonFromFile = reader.ReadToEnd();
		}
		
		List<Person> deserializedPeople = JsonSerializer.Deserialize<List<Person>>(jsonFromFile);
		foreach (var person in deserializedPeople)
		{
			Console.WriteLine($"Deserialized Person: {person.Name}, {person.Age}");
		}
	}
}