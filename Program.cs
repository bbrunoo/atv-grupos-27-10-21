using System;
using static System.Console;

namespace tarefa2710
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tabuada =  new string[10];
        
            //WriteLine($"Novo valor no index 2: {nomes[2]}");
                WriteLine("Digite o numero da tabuada");
            double num = Convert.ToInt32(ReadLine());
             

            for (int i = 1; i <= 10; i++)
            {
                 double r = num * i; 
                 WriteLine(num + "x" +  i + "=" + r );
            }   
        }
    }
}

