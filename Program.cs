using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Poo_ProdutoAtualizado
{
    class Program
    {


        static void Main(string[] args)
        {

            String nomeProd; //Nome do produto
            float valor; //Valor do produto
            int quantSoma; //Quantidade para somar
            int quantSub; //Quantidade para subtrair
            int quant; //Valor da quantidade
            int totalQuant; //Total da soma da quantidade
            int totalQuantSub; //Total da subtração da quantidade somada
            float total; //Valor total do produto em relação a quantidade de produtos
            float totalSom; //Valor total do produto após a soma
            float totalSub; //Valor total do produto após a subtração depois da soma
            

            Console.WriteLine("Entre com os produtos");
            Console.Write("Nome: ");
            nomeProd = Console.ReadLine();
            Console.Write("Preço: ");
            valor = float.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            quant = int.Parse(Console.ReadLine());
            Console.Clear();


            total = valor * quant; //Dando o valor total depois de multiplicar o valor inserido do preço do produto com a quantidade de produto inserido

            Console.WriteLine("Dados do produto: " + nomeProd + ", R$" + valor + "," + quant + " Unidades" + " Total: " + total);
            Console.WriteLine("-------------");

            Console.WriteLine("Digite o número a ser adicionado no estoque: ");
            quantSoma = int.Parse(Console.ReadLine());

            totalSom = total + (quantSoma * valor); //Dando o valor total da quantidade adicional do produto depois de somar o total do preço do produto em relação a quantidade no estoque com a multiplicação da quantidade adicional com o valor do produto
            totalQuant = quantSoma + quant; //Dando o valor total da quantidade como resultado total da soma da quantidade adicional com a quantidade que tinha anteriormente no estoque

            Console.Clear();
            Console.WriteLine("Dados atualizados: " + nomeProd + ", R$" + valor + "," + totalQuant + " Unidades" + " Total: " + totalSom);
            Console.WriteLine("-------------");
            Console.WriteLine("Digite o número a ser removido do estoque: ");
            quantSub = int.Parse(Console.ReadLine());

            totalSub = totalSom - (quantSub * valor); //Dando o valor total do valor do produto subtraindo o total da soma do valor em reais do estoque com a multiplicação da quantidade inserida pra ser removida do estoque com o valor de produto

            totalQuantSub = totalQuant - quantSub; //Dando o valor total da quantidade da subtração da quantidade total anterior depois de ter adicionado mais produtos subtraindo com a quantidade inserida pra retirada do produto do estoque

            Console.Clear();
            Console.WriteLine("Dados atualizados: " + nomeProd + ", R$" + valor + "," + totalQuantSub + " Unidades" + " Total: " + totalSub);

            Console.ReadKey();

        }
    }
}
