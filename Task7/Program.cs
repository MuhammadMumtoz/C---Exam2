var Persons = new List<Person> { };
System.Console.Write("Number of person: ");

int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    var person = new Person();
    System.Console.Write($"Name of person {i}: ");
    person.Name = Console.ReadLine();
    System.Console.Write($"Surname of person {i}: ");
    person.Surname = Console.ReadLine();
    System.Console.Write($"Age of person {i}: ");
    person.Age = Convert.ToInt32(Console.ReadLine());
    Persons.Add(person);
}


foreach (var item in Persons)
{
    System.Console.WriteLine("Person information");
    System.Console.WriteLine("Name: " + item.Name);
    System.Console.WriteLine("Surname: " + item.Surname);
    System.Console.WriteLine("Age: " + item.Age);
}