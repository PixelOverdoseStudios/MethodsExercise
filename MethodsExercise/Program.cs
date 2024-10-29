using System.Runtime.CompilerServices;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string pet;
            string petName;

            name = GetName();
            age = GetAge();
            pet = GetPet();
            petName = GetName();
            TellStory(name, age, pet, petName);
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
    }
}
