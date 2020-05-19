using System;

namespace MethodsExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            var total = Add(7, 17);
            var result = Multiply(5, 9);

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
