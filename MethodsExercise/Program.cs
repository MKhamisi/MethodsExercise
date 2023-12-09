using System;
using System.Drawing;
using System.Reflection;

namespace MethodsExercise
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }

     

        static void Main(string[] args)
        {
           

           //---------------Exercise 1 ---------------------------------
           //Your Name
           //Your Favorite Color
           //Your Favorite Animal
           //Your Favorite Band
    
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine($"Hi {yourName}, what is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine($"wow, {favColor} is a lovely color! May I ask what is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"I love {favAnimal}, they're such amazing species. What is yoyr favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"{favBand} are so cool!");


            Console.WriteLine($"Thanks for your time {yourName}. See your profile below");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine($"Name: {yourName}");
            Console.WriteLine($"Favorte Color: {favColor}");
            Console.WriteLine($"Favorite Animal: {favAnimal}");
            Console.WriteLine($"Favorite Band: {favBand}");

            //---------------Exercise 2 ---------------------------------
            //Add method
            //Subtract method
            //Multiply method
            //Divide method
            //Modulus method

            Console.WriteLine("--------------Exercise 2 ---------------------------");
            Console.WriteLine($"Addition: {Add(5, 10)}");
            Console.WriteLine($"Subtraction: {Subtract(20, 10)}");
            Console.WriteLine($"Multiplication: {Multiply(2, 4, 6)}");
            Console.WriteLine($"Division: {Divide(30, 5)}");

        }
    }
}

