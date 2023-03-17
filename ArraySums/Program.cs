using System;

namespace ArraySums

{  
     
    class Program 
    {
        static void Main(string[] args)
        {
            //ask the user to put a number of horizontal lines  
            Console.Write("insert a number of horizontal lines: ");

            //save the number in a variable int   
            int totalLinhas = int.Parse(Console.ReadLine());
            
            //ask the user to put a number of vertical lines  
            Console.Write("insert a number of vertical lines: ");

            //save the number in a variable int    
            int totalColunas = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            //create a matrix with the array float 
            float[,] matrix = new float[totalLinhas,totalColunas];
            float[] somaLinhas = new float[totalLinhas];
            float[] somaColunas = new float[totalColunas];   
            for (int linha = 0; linha < totalLinhas; linha++)
            {
                for (int coluna = 0; coluna < totalColunas; coluna++)
                {
                    Console.Write($"insert a value position for [{linha}, {coluna}]: ");
                    int value = int.Parse(Console.ReadLine());
                    matrix[linha,coluna] = value;
                    somaColunas[coluna] += value;
                    somaLinhas[linha] +=value;
                }
            }

            // printa a matriz para o user
            Console.WriteLine();    
            for (int linha = 0; linha < totalLinhas; linha++)
            {
                for (int coluna = 0; coluna < totalColunas; coluna++)
                {
                    Console.Write($"{matrix[linha,coluna]} ");
                }
                Console.WriteLine();    
            }

            // printa a soma das coluna para o user
            Console.WriteLine();  
            for (int i = 0; i < totalColunas; i++)
            {
                Console.WriteLine($"soma da coluna {i}: {somaColunas[i]}");      
            }

                 Console.WriteLine();  
            for (int i = 0; i < totalLinhas; i++)
            {
                Console.WriteLine($"soma da linha {i}: {somaLinhas[i]}");      
            }

            
        }
    }

}
