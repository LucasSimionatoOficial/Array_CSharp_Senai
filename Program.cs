using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] compras = {"maçã", "batata", "cenoura"};
            double[] preco = {1.10, 2.30, 4.50};
            int[] idades = {16, 17, 17};

            string[] nomesAlunos = new string[5];

            // Console.WriteLine(compras[2]);

            // string item = Console.ReadLine();

            // Console.WriteLine("Trocar batata pelo quê?");
            // compras[1] = Console.ReadLine();

            // Console.WriteLine(compras[1]);

            for (var i = 0; i < compras.Length; i++)
            {
                Console.WriteLine(compras[i] + ": R$" + preco[i]);
            }
        }
    }
}
