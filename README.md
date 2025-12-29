
# C# OOP Basic Examples

This repository contains simple **C# Object-Oriented Programming (OOP)** examples for beginners.  
Each example demonstrates how to create a **class**, define **fields**, use **methods**, and work with **constructors**.

---

##  Example 1: Student Class

**Concepts used:**
- Class creation
- Public fields
- Object creation
- Assigning values
- Displaying output

```csharp
class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "John";
        student1.Age = 15;

        Console.WriteLine(student1.Name);
        Console.WriteLine(student1.Age);
    }
}
```

**Output:**
```
John
15
```

---

##  Example 2: Dog Class

**Concepts used:**
- Class with method
- Calling a method using an object

```csharp
class Dog
{
    public string Breed;

    public void Bark()
    {
        Console.WriteLine("The dog is barking");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Breed = "Labrador";

        myDog.Bark();
    }
}
```

**Output:**
```
The dog is barking
```

---

##  Example 3: Car Class with Constructor

**Concepts used:**
- Constructor
- Passing values during object creation

```csharp
class Car
{
    public string Model;

    public Car(string model)
    {
        Model = model;
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Honda");
        Console.WriteLine(car1.Model);
    }
}
```

**Output:**
```
Honda
```

---

##  Topics Covered
- Classes and Objects
- Fields
- Methods
- Constructors
- Basic OOP principles in C#

---

###  How to Run
1. Open the project in Visual Studio or any C# IDE
2. Compile and run the `.cs` files
3. View output in the console
