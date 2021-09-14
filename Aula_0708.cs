using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0708
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            ////variaveis
            //int qtd;
            //double preco, total;

            ////Entradas
            //Console.Write("Insira a quantidade de maças compradas: ");
            //qtd = int.Parse(Console.ReadLine());

            ////processamento
            ////if(qtd>=12)
            ////{
            ////    preco = 1;
            ////}
            ////else
            ////{
            ////    preco = 1.3;
            ////}

            //preco = (qtd >= 12) ? 1 : 1.3;

            //total = qtd * preco;

            ////Saida
            //Console.WriteLine("O total da compra é: R$" + total);


            //Ex 2
            ////variaveis
            //int n1, n2, n3;

            ////Entrada
            //Console.Write("Insira o primeiro numero: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Insira o segundo numero: ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.Write("Insira o terceiro numero: ");
            //n3 = int.Parse(Console.ReadLine());

            ////processamento
            //if(n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("O maior é: " + n1);           
            //    if(n2 > n3)
            //    {
            //        Console.WriteLine("O segundo maior é: " + n2);
            //        Console.WriteLine("O terceiro maior é: " + n3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("O segundo maior é: " + n3);
            //        Console.WriteLine("O terceiro maior é: " + n2);
            //    }
            //}
            //else
            //{
            //    if(n2 > n3)
            //    {
            //        Console.WriteLine("O maior é: " + n2);
            //        if (n1 > n3)
            //        {
            //            Console.WriteLine("O segundo maior é: " + n1);
            //            Console.WriteLine("O terceiro maior é: " + n3);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O segundo maior é: " + n3);
            //            Console.WriteLine("O terceiro maior é: " + n1);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("O maior é: " + n3);
            //        if (n1 > n2)
            //        {
            //            Console.WriteLine("O segundo maior é: " + n1);
            //            Console.WriteLine("O terceiro maior é: " + n2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O segundo maior é: " + n2);
            //            Console.WriteLine("O terceiro maior é: " + n1);
            //        }
            //    }
            //}

            //Ex 3
            ////variaveis
            //double salario, total_vendas, comiss;

            ////Entradas
            //Console.Write("Insira o salario fixo: ");
            //salario = double.Parse(Console.ReadLine());
            //Console.Write("Insira o total de vendas deste vendedor: ");
            //total_vendas = double.Parse(Console.ReadLine());

            ////processamento
            ////if(total_vendas <= 1500)
            ////{
            ////    comiss = total_vendas * 0.03;
            ////}
            ////else
            ////{
            ////    comiss = (1500 * 0.03) + (total_vendas - 1500) * 0.05;
            ////}

            ////salario += comiss;

            //salario += (total_vendas <= 1500) ? total_vendas * 0.03 : (1500 * 0.03) + (total_vendas - 1500) * 0.05;

            ////Saida
            //Console.WriteLine("O valor a pagar para este vendedor é: R$" + salario);

            ////Ex 4
            ////variavel
            //int ano;

            ////Entradas
            //Console.Write("Insira o ano: ");
            //ano = int.Parse(Console.ReadLine());

            ////processamento
            //if (
            //    ((ano % 4 == 0) && !(ano % 100 == 0))
            //    ||
            //    (ano % 400 == 0)
            //  )
            //{
            //    Console.WriteLine("É BISSEXTO!");
            //}
            //else
            //    Console.WriteLine("NÃO é bissexto!");

            ////Ex 5
            //double entrada;
            //int dia;           

            ////Entradas
            //Console.Write("Insira o valor da entrada da danceteria: ");
            //entrada = double.Parse(Console.ReadLine());
            //Console.Write("Insira o dia da semana:\n" +
            //    "1 - DOMINGO\n" +
            //    "2 - SEGUNDA\n" +
            //    "3 - TERÇA\n" +
            //    "4 - QUARTA\n" +
            //    "5 - QUINTA\n" +
            //    "6 - SEXTA\n" +
            //    "7 - SABADO\n" +
            //    "Insira o numero do dia desejado: ");
            //dia = int.Parse(Console.ReadLine()); 

            ////processamentos
            //if(dia == 2 || dia == 3 || dia ==5)
            //{
            //    entrada -= 10;
            //}
            //Console.Write("Terá musica ao vivo (S/N): ");
            //string musica = Console.ReadLine();
            //if(musica.ToUpper() == "S")
            //{
            //    entrada += 7.5;
            //}

            //Console.WriteLine("Valor final de entrada: R$" + entrada);           

            //---------------------------------------------------------
            //Exemplos
            int[] Lista = { 2, 5, 8, 10 };

            for(int pos = 0; pos<=3; pos++)
            {
                Console.WriteLine(Lista[pos]);
            }


            foreach(int pos in Lista)
            {
                Console.WriteLine(pos);
            }

            


            Console.ReadLine();



        }
    }
}
