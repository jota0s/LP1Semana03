using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
          //create a string that ask the user to write something and save that
          Console.WriteLine("write a string");
          String r = Console.ReadLine();

          //create a string that ask the user to write something,
          // convert to char and save that
          Console.WriteLine("write a char");
          Char b = Char.Parse(Console.ReadLine());
          
          //create a new final string
          string finalR ="";

          //init a foreach that reads the char on the string an creates 
          //a new string without that char
          foreach (char p in r)
          {
             if (p!=b)
             {
              finalR += p;
             }
          }
          //print the new string
          Console.WriteLine(finalR);
        }
    }
}
