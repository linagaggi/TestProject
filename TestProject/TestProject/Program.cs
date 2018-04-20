using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your fav. animal?");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case Animals.Fish:
                    Console.WriteLine("You like Fish");
                    break;
                case Animals.Bird:
                    Console.WriteLine("You like Birds");
                    break;
                case Animals.Cat:
                    Console.WriteLine("You like Cats");
                    break;
                case Animals.Dog:
                    Console.WriteLine("You like Dog");
                    break;
                case Animals.Elephant:
                    Console.WriteLine("You like Elephants");
                    break;
                case Animals.Giraff:
                    Console.WriteLine("You like Giraffs");
                    break;
                case Animals.Frog:
                    Console.WriteLine("You like Frogs");
                    break;
                case Animals.Monkey:
                    Console.WriteLine("You like Monkeys");
                    break;
                case Animals.Lion:
                    Console.WriteLine("You like Lions");
                    break;
                case Animals.Bear:
                    Console.WriteLine("You like Bears");
                    break;
                default:
                    Console.WriteLine("You don't like animals");
                    break;
            }
            Console.ReadLine();
        }
    }
}
