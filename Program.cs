using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Pessoas_Programação
{
    

    class Program
    {


        static void Main(string[] args)
        {

            string NomeA, NomeB;
            int Sal1, Sal2, IdadeA, IdadeB;
            int medSal;

            Console.WriteLine("=======================================");
            Console.WriteLine("Digite o Nome, idade e salário da pessoa 1:");
            Console.Write("Nome: ");
            NomeA = Console.ReadLine();
            Console.Write("Idade: ");
            IdadeA = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            Sal1 = int.Parse(Console.ReadLine());
            Console.ReadLine();
            

            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("Digite o Nome, idade e salário da pessoa 2:");
            Console.Write("Nome: ");
            NomeB = Console.ReadLine();
            Console.Write("Idade: ");
            IdadeB = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            Sal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================================");
            Console.Clear();

            medSal = (Sal1 + Sal2) / 2;

            if (IdadeA > IdadeB)
            {
                Console.WriteLine("O nome da pessoa mais velha é " + NomeA);
                Console.WriteLine("A média salarial é: " + medSal);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O nome da pessoa mais velha é " + NomeB);
                Console.WriteLine("A média salarial é: " + medSal);
                Console.ReadKey();
            }

            

        }
    }
}
