using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var favBand = Console.ReadLine();

            Console.WriteLine($"{name} is an {favColor} {favAnimal} that likes to eat people while listening to {favBand}!");
        }

    }
}
