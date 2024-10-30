using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //==EXERCISE 1: Creating a Story==//
            // Completed the bonus challenge using methods outside of main.

            string name;
            int age;
            string pet;
            string petName;

            name = GetName();
            age = GetAge();
            pet = GetPet();
            petName = GetName();
            TellStory(name, age, pet, petName);

            //==EXERCISE 2: Math Operations Methods==//
            // Completed the bonus challenge using params.

            Console.WriteLine(Add(7, 8, 5, 10));
            Console.WriteLine(Subtraction(100, 25, 33));
            Console.WriteLine(Multiply(5, 5, 5));
            Console.WriteLine(Division(100, 5, 2));
            
        }
        
        static string GetName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        static int GetAge()
        {
            Console.WriteLine("How old are you?");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string GetPet()
        {
            Console.WriteLine("What kind of pet would you like to have?");
            return Console.ReadLine();
        }

        static string PetName()
        {
            Console.WriteLine("What is the name of your pet?");
            return Console.ReadLine();
        }

        static void TellStory(string name, int age, string pet, string petName)
        {
            Console.WriteLine($"{name} is {age} years old. They have a {pet} who's named {petName}.");
        }

        static int Add(params int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
                total += number;

            return total;
        }
        static int Subtraction(params int[] numbers)
        {
            int total = numbers[0];

            for(int i = 1; i < numbers.Length; i++)
                total -= numbers[i];

            return total;
        }

        static int Multiply(params int[] numbers)
        {
            int total = 1;

            foreach (int number in numbers)
                total *= number;

            return total;
        }

        static int Division(params int[] numbers)
        {
            int total = numbers[0];

            for(int i = 1; i < numbers.Length; i++)
                total /= numbers[i];

            return total;
        }
    }
}
