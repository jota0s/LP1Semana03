using System;
using System.Globalization;


namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            //  para o progama conseguir ler a  ","
           CultureInfo culture = CultureInfo.InvariantCulture;

            //  Declarar as matrizes
            float [,] matrix1 = new float [2,2];
            float [,] matrix2 = new float [2,1];
            float [,] result = new float [2,1];

            //  receber os valores da linha de comandos e preencher a matrix1
            matrix1[0, 0] = float.Parse(args[0], culture);
            matrix1[0, 1] = float.Parse(args[1], culture);
            matrix1[1, 0] = float.Parse(args[2], culture);
            matrix1[1, 1] = float.Parse(args[3], culture);
            
            //  receber os valores da linha de comandos e preencher a matrix1
            matrix2[0, 0] = float.Parse(args[4], culture);
            matrix2[1, 0] = float.Parse(args[5], culture);

            //percorre as linhas da matrix1
            for (int i = 0; i <matrix1.GetLength(0); i++)
            {   
                //inicializa o valor da posição [i,0]
                result[i,0] = 0;

                //percorre as colunas da matrix1
                for (int a = 0; a < matrix1.GetLength(1); a++)
                {   
                    //calcula o produto das matrizes e acumula o valor no result
                    result[i,0] += matrix1[i, a] * matrix2[a,0];
                }
                
            }
            
            //imprime os resultados da multiplicação 
             for (int i = 0; i < result.GetLength(0); i++)
            {   
                //imprime com o resultado alinhado a direita com distancia de 7 caracteres
                Console.WriteLine($"|{result[i, 0],7:F2}|"); 
            }
                
        }
    }
}
