using System.Xml.Linq;

class Person
{
    public string name;
    public int age;
    public Person() { name = "Default"; age = 0; }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] newPerson = new Person[10];

        for (int i = 0; i < 10; i++)
        {
            newPerson[i] = new Person();
            Console.Write("Enter a name: ");
            newPerson[i].name = Console.ReadLine();
            Console.Write("Enter the age: ");
            newPerson[i].age = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        List<Person> persons=new List<Person>();
        for (int i = 0; i < 10; i++)
        {
           persons.Add( new Person() { name = newPerson[i].name, age = newPerson[i].age });
        }
        Console.WriteLine("List of people:\n");
        int number = 1;
        persons.ForEach(p => { Console.WriteLine($"Hi, my name is {p.name}, i'm {p.age} years old, i'm number {number}\n"); number++; });
    }
}