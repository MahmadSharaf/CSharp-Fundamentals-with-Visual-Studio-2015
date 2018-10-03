
using System; /*main Space to use Console Class*/

namespace _1.Hello 
{
    class Program 
    {
        static void Main(string[] args) /*args are the input send by the user*/
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine(); /*Scans for an input*/
            Console.WriteLine("How many hours have you slept? ");
            int hourOfSleep = int.Parse(Console.ReadLine()); /*Readline expects strings so it needed to be converted explicity*/
            Console.WriteLine("Hello," + name); /*Prints out*/
            if (hourOfSleep > 8)
            {
                Console.WriteLine("You are well rested.");
            }
            else
            {
                Console.WriteLine("You need more sleep.");
            }
        }
    }
}
