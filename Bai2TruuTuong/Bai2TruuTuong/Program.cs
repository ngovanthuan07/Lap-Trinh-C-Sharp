using System;

namespace Bai2TruuTuong
{
    class Animal
    {
        public string eat()
        {
            return "";
        }

        public string makeSound()
        {
            return "";
        }
    }

    class Cat:Animal
    {
        public string eat()
        {
            return "Meo an ca";
        }

        public string makeSound()
        {
            return "Meo meo";
        }

        public void run()
        {
            Console.WriteLine("Cat: " + eat() + makeSound());
        }
    }

    class Bird : Animal
    {
        public string eat()
        {
            return "Chim an sau";
        }

        public string makeSound()
        {
            return "Chip chip";
        }

        public void fly()
        {
            Console.WriteLine("Bird: " + eat() + makeSound());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.run();
            Bird bird = new Bird();
            bird.fly();

            Console.ReadKey();

        }
    }
}
