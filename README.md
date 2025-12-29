# Sleha-Javed
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
 Output
John
15
Example 2
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
 Output
The dog is barking
Example 3: 
Car Class with Constructor
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
Output
Honda
