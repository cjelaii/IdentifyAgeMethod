using System;

namespace IdentifyAgeMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of birth: ");
            int yearOfBirth = Convert.ToInt16(Console.ReadLine());

            int age = 2024 - yearOfBirth;
            string generation = GetGeneration(age);
            string stage = GetLifeStage(age);

            Console.WriteLine($"{age} years old, {generation}, {stage}");
        }

        static string GetGeneration(int age)
        {
            if (age >= 79 && age <= 96)
            {
                return "The Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                return "Baby Boomers";
            }

            else if (age >= 0 && age <= 11)
            {
                return "Gen Alpha";
            }
            else
            {
                return "Invalid Age";
            }
        }

        static string GetLifeStage(int age)
        {
            if (age >= 0 && age <= 3)
            {
                return "Infant";
            }
            else if (age >= 4 && age <= 6)
            {
                return "Early Childhood";
            }

            else if (age > 80)
            {
                return "Late Adulthood";
            }
            else
            {
                return "Invalid Age";
            }
        }
    }
}