﻿﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

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
        var p = new Person("Misi", 23, Code.Error);
        var p2 = new Person("Visi", 23, Code.Safe);
        List<Person> people = new();
        people.Add(p);
        people.Add(p2);

        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Person>));
        FileStream stream = new FileStream("person.json", FileMode.Create);
        using (var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true, true, "  "))
        {
            ser.WriteObject(writer, people);
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