Encapsulation in C# is a fundamental principle of object-oriented programming (OOP) that involves bundling data (attributes) and methods (behaviors) that operate on the data into a single unit, called a class. The key concept behind encapsulation is to hide the internal state of an object and only expose a controlled interface to interact with it. This helps in achieving data hiding, abstraction, and modularity, which are essential for building maintainable and scalable software systems.

In C#, encapsulation is typically achieved using access modifiers such as `public`, `private`, `protected`, and `internal`. These modifiers control the visibility and accessibility of members (fields, properties, and methods) of a class.

- **Public**: Members with the `public` access modifier are accessible from any code that can access the class, whether it's from within the same assembly or from external assemblies.

- **Private**: Members with the `private` access modifier are accessible only within the same class. They are not accessible from outside the class, including derived classes.

- **Protected**: Members with the `protected` access modifier are accessible within the same class and by derived classes. They are not accessible from outside the class or its derived classes.

- **Internal**: Members with the `internal` access modifier are accessible within the same assembly but not from outside the assembly.

Encapsulation also involves using properties and methods to provide controlled access to the internal state of an object. By encapsulating data within properties, you can enforce validation rules, calculate derived values, and ensure proper state management.

Here's a simple example demonstrating encapsulation in C#:

```csharp
using System;

public class Person
{
    private string name;
    private int age;

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
            if (value >= 0)
                age = value;
            else
                throw new ArgumentException("Age cannot be negative.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John";
        person.Age = 30;

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
```

In this example, the `Person` class encapsulates the `name` and `age` fields using properties `Name` and `Age`, respectively. The properties provide controlled access to these fields by enforcing rules (such as age cannot be negative). The encapsulated data is hidden from external code, ensuring data integrity and allowing for easier maintenance and modification of the class implementation.
