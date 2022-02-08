using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int B = int.Parse(Console.ReadLine());
            int R = A + B;
            int Resultado = A * B;

            if (A == B)
            {
                Console.WriteLine("O resultado de A+B é igual a " + R);
            }
            else
            {
                Console.WriteLine("O resultado de A*B é igual a " + Resultado);
            }
            
            

        }
    }
}
