using System;

struct Dog
{
    public string Name;
    public string Breed;
    public int Age;
    public double Weight;

    // A method for behavior
    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof! 🐾");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} is eating {food}.");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Breed: {Breed}");
        Console.WriteLine($"Age: {Age} years old");
        Console.WriteLine($"Weight: {Weight} lbs");
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        // Create a Dog struct instance
        Dog myDog;

        myDog.Name = "Buddy";
        myDog.Breed = "Golden Retriever";
        myDog.Age = 3;
        myDog.Weight = 70.5;

        myDog.ShowInfo();
        myDog.Bark();
        myDog.Eat("kibble");
    }
}
