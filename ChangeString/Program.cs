using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("write a string");
          String r = Console.ReadLine();


          Console.WriteLine("write a char");
          Char b = Char.Parse(Console.ReadLine());

          string finalR ="";


          foreach (char p in r)



          {
             if (p!=b)
             {
              finalR += p;
             }



          }

          Console.WriteLine(finalR);



        




        }
    }
}
