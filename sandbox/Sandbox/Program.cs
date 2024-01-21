using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        // Person p1 = new Person();
        // p1._firstName = "Rodolfo";
        // p1._lastName = "Ortuño";
        // p1._age = 43;

        // Person p2 = new Person();
        // p2._firstName = "John";
        // p2._lastName = "Connor";
        // p2._age = 30;

        // List<Person> people = new List<Person>();
        // people.Add(p1);
        // people.Add(p2);

        // foreach (Person p in people)
        // {
        //     Console.WriteLine(p._firstName);
        // }
        // SaveToFile(people);

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);


        }

    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");

        string filename = "people.txt";
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputfile.WriteLine($"{p._firstName}ºº{p._lastName}ºº{p._age}");
            }
        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Person> people = new List<Person>();

        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string[] parts = line.Split("ºº");

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);




        }

        return people;
    }
}