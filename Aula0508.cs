using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0508
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exerc 1
            ////variaveis
            //int qtd;
            //double total, preco;

            ////Entrada
            //Console.Write("Insira a quantidade de maças compradas: ");
            //qtd = int.Parse(Console.ReadLine());

            ////Processamento
            ////if(qtd>=12)
            ////{
            ////    preco = 1;
            ////}
            ////else
            ////{
            ////    preco = 1.30;
            ////}

            //preco = (qtd>=12) ? 1 : 1.30;

            //total = qtd * preco;

            ////Saidas
            //Console.WriteLine("O valor total da compra é: R$" + total);


            //Exerc 2
            //variaveis
            //int n1, n2, n3;

            ////Entrada
            //Console.Write("Insira o primeiro numero: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Insira o segundo numero: ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.Write("Insira o terceiro numero: ");
            //n3 = int.Parse(Console.ReadLine());



            ////processamento
            //if((n1>n2) && (n1>n3))
            //{
            //    Console.WriteLine("O maior é: " + n1);
            //    if(n2>n3)
            //    {
            //        Console.WriteLine("O segundo maior: " + n2);
            //        Console.WriteLine("O menor é: " + n3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("O segundo maior: " + n3);
            //        Console.WriteLine("O menor é: " + n2);
            //    }
            //}
            //else //N1 não é o maior de todos
            //{
            //    if(n2>n3)
            //    {
            //        Console.WriteLine("O maior é: " + n2);
            //        if (n1 > n3)
            //        {
            //            Console.WriteLine("O segundo maior: " + n1);
            //            Console.WriteLine("O menor é: " + n3);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O segundo maior: " + n3);
            //            Console.WriteLine("O menor é: " + n1);
            //        }
            //    }
            //    else //n3 maior de todos
            //    {
            //        Console.WriteLine("O maior é: " + n3);
            //        if (n1 > n2)
            //        {
            //            Console.WriteLine("O segundo maior: " + n1);
            //            Console.WriteLine("O menor é: " + n2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O segundo maior: " + n2);
            //            Console.WriteLine("O menor é: " + n1);
            //        }
            //    }

            //}

            //Exerc 3
            //variaveis
            //double salario, total, val_comiss, salario_final;

            ////Entradas
            //Console.Write("Insira o salario fixo do vendedor: ");
            //salario = double.Parse(Console.ReadLine());
            //Console.Write("Insira o total de vendas deste vendedor: ");
            //total = double.Parse(Console.ReadLine());

            ////Processamento
            ////if(total <= 1500)
            ////{
            ////    val_comiss = total * 0.03;
            ////}
            ////else
            ////{
            ////    val_comiss = (1500 * 0.03) + (total - 1500) * 0.05;
            ////}

            //val_comiss = (total <= 1500) ? total * 0.03 : (1500 * 0.03) + (total - 1500) * 0.05;

            //salario_final = salario + val_comiss;

            ////Saida
            //Console.WriteLine("O valor a pagar para o vendedor é: R$" + salario_final);

            //Ex 4
            //int ano;

            ////Entrada
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
            ////Variaveis
            //int dia;
            //double entrada;
            //string musica;

            ////Entrada
            //Console.Write("Insira o valor da entrada: ");
            //entrada = double.Parse(Console.ReadLine());
            //Console.Write("Insira o numero referente ao dia da semana:\n" +
            //    "1 - DOMINGO\n" +
            //    "2 - SEGUNDA\n" +
            //    "3 - TERÇA\n" +
            //    "4 - QUARTA\n" +
            //    "5 - QUINTA\n" +
            //    "6 - SEXTA\n" +
            //    "7 - SABADO\n" +
            //    "Insira a opção desejada: ");
            //dia = int.Parse(Console.ReadLine());

            //if (dia == 2 || dia == 3 || dia == 5)
            //    entrada -= 10;

            //Console.Write("Terá musica ao vivo (S/N): ");
            //musica = Console.ReadLine();           

            //if (musica.ToUpper() == "S")
            //    entrada += 7.5;

            ////Saida
            //Console.WriteLine("O valor final a pagar: R$" + entrada);

            int[] Lista = { 2, 3, 4, 5, 6, 7, 8, 10 };
            for(int pos = 0; pos <=7; pos++)
            {
                Console.WriteLine(Lista[pos]);
            }

            Console.WriteLine("----------------------");

            foreach(int val in Lista)
            {
                Console.WriteLine(val);
            }


            Console.ReadLine();
        }
    }
}
