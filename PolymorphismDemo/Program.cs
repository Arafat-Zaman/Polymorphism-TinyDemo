using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.Speak(); // Outputs: The dog barks.
        myCat.Speak(); // Outputs: The cat meows.
    }
}
