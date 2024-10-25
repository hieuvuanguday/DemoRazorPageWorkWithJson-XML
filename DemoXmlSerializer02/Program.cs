using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DemoXmlSerializer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            String fileName = "people.xml";

            var people = new List<Person> 
            {
                new Person(30000M){
                    FirstName = "Alice", 
                    LastName = "Smith", 
                    DateOfBirth = new DateTime(1972, 3, 16) 
                },
                new Person(20000M){
                    FirstName = "Charlie", 
                    LastName = "Cox", 
                    DateOfBirth = new DateTime(1984, 5, 4),
                    Children = new HashSet<Person>{
                        new Person(0M)
                        {
                            FirstName = "Sally",
                            LastName = "Cox",
                            DateOfBirth = new DateTime(2000, 7, 12)
                        }
                    }
                }
            };

            var xs = new XmlSerializer(typeof(List<Person>));
            using FileStream stream = File.Create(fileName);
            xs.Serialize(stream, people);
            Console.WriteLine("Written {0:N0} bytes of XML to {1}", new FileInfo(fileName).Length, fileName);
            stream.Close();

            Console.WriteLine(new string('*', 30));
            Console.WriteLine(File.ReadAllText(fileName));
            Console.WriteLine(new string('*', 30));

            using FileStream xmlLoad = File.Open(fileName, FileMode.Open);
            var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);
            foreach (var item in loadedPeople)
            {
                Console.WriteLine($"{item.LastName} has " + $"{item.Children?.Count ?? 0} children.");
            }
            xmlLoad.Close();
            Console.ReadLine();
        }
    }
}
