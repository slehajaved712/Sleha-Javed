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