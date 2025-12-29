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