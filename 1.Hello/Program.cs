
using System; /*main Space to use Console Class*/

namespace _1.Hello 
{
    class Program 
    {
        static void Main(string[] args) /*args are the input send by the user*/
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine(); /*Scans for an input*/
            Console.WriteLine("Hello," + name); /*Prints out*/
        }
    }
}
