using System;

namespace ArraySums

{  
     
    class Program 
    {
        static void Main(string[] args)
        {
            //ask the user to put a number of horizontal lines  
            Console.WriteLine("insert a number of horizontal lines ");

            //save the number in a variable int   
            int totalLinhas = int.Parse(Console.ReadLine());
            
            //ask the user to put a number of vertical lines  
            Console.WriteLine("insert a number of vertical lines ");

            //save the number in a variable int    
            int totalColunas = int.Parse(Console.ReadLine());

            //create a matrix with the array float 
            float[,] matrix = new float[totalLinhas,totalColunas];

            
            for( int linha= 0; linha<totalLinhas; linha++) 
            {
                for( int coluna = 0; coluna<totalColunas; coluna++)
                {
                     Console.WriteLine($"insert a value to position  ");

                } 
               
               
                   
            }   



        }
    }

}
