using System.Xml.Linq;

class Person
{
    public string name;
    public int age;
    public Person () { name = "Default"; age = 0; }
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
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Hi, my name is {newPerson[i].name}, i'm {newPerson[i].age} years old\n");
        }
    }
}