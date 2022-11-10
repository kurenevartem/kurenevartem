using System.Collections.Generic;
using System.Xml.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Sergei", "Oleg", "Artem", "Anelia", "Madina", "Tanya", "Rustam", "Egor", "Andrey", "Anton" };
        List<Person> people = new List<Person>(10);
        for (int i = 0; i < 10; i++)
        {
            Random rnd = new Random();
            int age = rnd.Next(18, 30);
            people.Add(new Person() { Name = names[i], Age = age });
        }
        int number = 1;
        people.ForEach(p => { Console.WriteLine($"Hi, my name is {p.Name}, i'm {p.Age} years old, i'm number {number}\n"); number++; });
    }
}

