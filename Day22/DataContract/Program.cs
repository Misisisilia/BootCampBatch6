﻿using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
// using Newtonsoft.Json;
public enum Code
{
	Safe = 0,
	Error = 1
}
[DataContract]
public class Person
{
	[DataMember]
	private string name;

	[DataMember]
	internal int age;

	[DataMember]
	private Code code;

	public Person(string name, int age, Code code)
	{
		this.name = name;
		this.age = age;
		this.code = code;
	}

	public string GetName()
	{
		return name + " " + (int)code;
	}
}

class Program
{
	static void Main()
	{
		var person1 = new Person("Misi", 23, Code.Error);
		var person2 = new Person("Visi", 23, Code.Safe);
		var person3 = new Person("Ica", 16, Code.Safe);
		List<Person> people = new();
		people.Add(person1);
		people.Add(person2);
		people.Add(person3);

		DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Person>));
		using (FileStream stream = new FileStream("person.json", FileMode.OpenOrCreate))
		{
			ser.WriteObject(stream, people);
		}

		List<Person> importPerson;
		using (FileStream stream2 = new FileStream("person.json", FileMode.Open))
		{
			importPerson = (List<Person>)ser.ReadObject(stream2);
		}

		foreach (var person in importPerson)
		{
			Console.WriteLine(person.GetName());
		}
	}
}