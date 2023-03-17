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
            //create a float for somalinhas and somacolunas 
            float[,] matrix = new float[totalLinhas,totalColunas];
            float[] somaLinhas = new float[totalLinhas];
            float[] somaColunas = new float[totalColunas];   

            //create a for to go through the matrix and asks 
            //the user to insert a value position 
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

            Console.WriteLine();    

            //create a for to go through the linhas of the matrix
            //And print the linha and coluna of the matrix
            for (int linha = 0; linha < totalLinhas; linha++)
            {
                for (int coluna = 0; coluna < totalColunas; coluna++)
                {
                    Console.Write($"{matrix[linha,coluna]} ");
                }
                Console.WriteLine();    
            }

            
            Console.WriteLine();  
            //for to make the add of the Colunas
            for (int i = 0; i < totalColunas; i++)
            {
                Console.WriteLine($"soma da coluna {i}: {somaColunas[i]}");      
            }

                 Console.WriteLine();  
            
            //for to make the add of the linhas
            for (int i = 0; i < totalLinhas; i++)
            {
                Console.WriteLine($"soma da linha {i}: {somaLinhas[i]}");      
            }

            
        }
    }

}
