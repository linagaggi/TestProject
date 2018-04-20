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
                default:
                    Console.WriteLine("You don't like animals");
                    break;
            }
            Console.ReadLine();
        }
    }
}
