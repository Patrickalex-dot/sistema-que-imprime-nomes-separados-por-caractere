using System;

namespace sistema_que_imprime_nomes_separados_por_caractere
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nomes = new string[10];

            for (int i = 0; i < Nomes.Length; i++)
            {
                Console.WriteLine("digite 10 nomes");
                Nomes[i] = Console.ReadLine();
            }

            for (int i = 0; i < Nomes.Length; i++)
            {
                Console.Write($"{Nomes[i]}");
                Console.Write($"-OU-");
            }
        }
    }
}
