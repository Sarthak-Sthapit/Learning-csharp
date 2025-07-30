using System;

class InheritanceExample
{

    class Animal
    {
        public string? Name;

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }


    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} says: Woof! ");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow! ");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a name for the Dog: ");
        Dog dog = new Dog();
        dog.Name = Console.ReadLine();
        dog.Eat();
        dog.Bark();
        dog.Sleep();

        Console.WriteLine();

        Console.Write("Enter a name for the Cat: ");
        Cat cat = new Cat();
        cat.Name = Console.ReadLine();
        cat.Eat();
        cat.Meow();
        cat.Sleep();
    }
}
