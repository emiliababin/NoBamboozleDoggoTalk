using System;
using System.Runtime.CompilerServices;

namespace DoggosBeingDoggos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Henlo, Fren!");
            Console.WriteLine("Whamt is yourm namem?");
                string name = Console.ReadLine();
            Console.WriteLine("Henlo, " + name + "!");
            Console.WriteLine("\t Nice to meat you!");
            Console.WriteLine("Type 'Henlo' if goob");

            string Karen1 = Console.ReadLine();
            if ((Karen1 == "Henlo") || (Karen1 == "henlo"))
            {

                Console.WriteLine("Thamks for henlo!");
                Console.WriteLine("\t Like you!");
                Console.WriteLine();
                Console.WriteLine("Do youm likem doggos?");
            }
            else
            {
                Console.WriteLine("FURK YOU KAREN");
                Console.WriteLine("GAMEMN OVERM!");
            }

            string Karen2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if ((Karen2 == "Yes") || (Karen2 == "yes") || (Karen2 == "YES"))
            {
                Console.WriteLine("\t DOGGO HAPP!");
                Console.WriteLine("Pressm any button to continyoo");
                Console.ReadKey();
                Console.WriteLine("\t Hab any chimken?");
                Console.WriteLine("Say the thumth Karen Yes or No?");
                string chimken = Console.ReadLine();
                if ((chimken == "Yes") || (chimken == "yes") || (chimken == "YES")) ;
                {
                    Console.WriteLine("Oh " + name + ", no bamboolze? Type 'no'");
                    string nobamboo = Console.ReadLine();
         

                }

                Console.WriteLine(name + " Doggo im heaben...");

            }
            else
            {
                Console.WriteLine("FURK YOU KAREN!");
                Console.WriteLine("Game overm :((((((");

            }

            Console.WriteLine("");
            Console.WriteLine("Now we are all happier :))))"); 
        }
    }
}


