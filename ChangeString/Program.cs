using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            string d;
            char c;

            Console.Write("Ctring: ");
            d = Console.ReadLine();

            Console.Write("Caráter: ");
            c = Console.ReadKey().KeyChar;

            string resultado = "";
            foreach (char item in d)
            {
                if (item ==c)
                {
                    resultado += "x";
                }

                else 
                {
                    resultado += item;
                }
            }
        
            Console.WriteLine(c);
            Console.Write("Será impresso: " + resultado);
        }
    }
}
