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