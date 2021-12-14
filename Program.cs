using System;

namespace Assignment1SyedAhmed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Questions");
            // create variables 
            string firstName;
            string lastName;
            string nation;
            string school;
            string activity;
            string resturaunt; 
            string song;
            string drink;
            string degree;
            string preference;

            //user recieves questions

            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();
            Console.Write("Please enter your nation: ");
            nation = Console.ReadLine();
            Console.Write("Please enter where you currently go to school: ");
            school = Console.ReadLine();
            Console.Write("Please enter your favorite activity: ");
            activity = Console.ReadLine();
            Console.Write("Please enter your favorite resturaunt: ");
            resturaunt = Console.ReadLine();
            Console.Write("Please enter your favorite song: ");
            song = Console.ReadLine();
            Console.Write("Please enter your favorite drink: ");
            drink = Console.ReadLine();
            Console.Write("Please enter your degree if attending school: ");
            degree = Console.ReadLine();
            Console.Write("Please enter your romantic preference: ");
            preference = Console.ReadLine();


            //biography with answers to questions asked

            Console.WriteLine(" ");

            Console.WriteLine("Hello my first name is " + firstName + " and my last name is " + lastName + ". I am from " + nation + ". I go to school at "
                + school + ". My favorite activity is " + activity + " . My most juicy resturaunt that I love the most is " + resturaunt + ". My favorite song is " + song +
                ". The greatest drink ever created is " + drink + ". The degree that I am studying towards in school is " + degree + ". My top preference in a romantic partner is " +
                preference);
        }
    }
}
