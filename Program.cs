public class Person
{
    // Private fields to encapsulate data
    private string name;
    private int age;

    // Public properties to provide controlled access to the fields
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if(value >= 0)
                age = value;
            else
                throw new ArgumentException("Age cannot be negative.");
        }
    }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display information about the person
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Person class
        Person person = new Person("John", 30);

        // Accessing properties to set and get data
        person.Name = "Alice";
        person.Age = 25;

        // Displaying information about the person
        person.DisplayInfo();

        // Error handling for invalid age
        try
        {
            person.Age = -5; // Trying to set a negative age
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
