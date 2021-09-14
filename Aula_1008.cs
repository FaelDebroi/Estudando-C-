using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1008
{
    class Program
    {

        static int Soma(int n1, int n2)
        {
            //int resultado;
            //resultado = n1 + n2;
            return n1 + n2; //resultado;
        }

        static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        static void Troca(ref int abacaxi,ref int batata)
        {
            int temp;
            temp = abacaxi;
            abacaxi = batata;
            batata = temp;
        }

        static void separador()
        {
            Console.WriteLine("-------------------------------------");
        }


        static void Main(string[] args)
        {

            int a, b;
            Console.Write("Insira o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B:");
            b = int.Parse(Console.ReadLine());

            Troca(ref a,ref b);

            Console.WriteLine("O valor de A: " + a + "\nO valor de B: " + b);


            //Ex 1
            //for(int linha = 1; linha <=7; linha++)
            //{
            //    for (int num = 1; num <= linha; num++)
            //    {
            //        Console.Write(num);
            //    }
            //    Console.WriteLine();
            //}


            //Ex 2
            //const int col = 7;
            //for (int linha = 1; linha <= col; linha++)
            //{
            //    for (int num = 1; num <= linha; num++)
            //    {
            //        Console.Write(num);
            //    }
            //    for(int ast=col-linha; ast>0;ast--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //EX 3
            //int n1, n2;

            ////Entradas
            //Console.Write("Insira o primeiro numero: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Insira o segundo numero: ");
            //n2 = int.Parse(Console.ReadLine());

            ////processamento
            //while(n2 == 0)
            //{
            //    Console.WriteLine("O valor 0 não é válido para o segundo numero!");
            //    Console.Write("Insira novamente o segundo numero: ");
            //    n2 = int.Parse(Console.ReadLine());
            //}

            ////Saida
            //Console.WriteLine("O valor de " + n1 + " / " + n2 + " = " +
            //    (double)n1 / n2);

            //Ex 4
            //int idade, maisVelho=0;
            //double altura, maisAlto = 0;

            ////Entradas
            //for(int pessoa = 1; pessoa <= 5; pessoa++)
            //{
            //    Console.Write("Informe a idade da pessoa " + pessoa + ": ");
            //    idade = int.Parse(Console.ReadLine());
            //    Console.Write("Informe a altura da pessoa " + pessoa + ": ");
            //    altura = double.Parse(Console.ReadLine());

            //    if(idade > maisVelho)
            //        maisVelho = idade;
            //    if(altura > maisAlto)
            //        maisAlto = altura;
            //}

            ////Saida
            //Console.WriteLine("O mais velho tem " + maisVelho + " anos e o mais alto tem " +
            //    maisAlto + "m");

            //EX 5
            //int numAlunos = 0;
            //double notas = 0, mediaSala;

            //do
            //{
            //    numAlunos++;
            //    //Entrada
            //    Console.WriteLine("Insira a media do aluno " + numAlunos + ": ");
            //    notas += double.Parse(Console.ReadLine());

            //    Console.WriteLine("Existe outro aluno para leitura de média(S/N)?");
            //} while (Console.ReadLine().ToUpper() == "S");

            ////processa - SAIDA
            //Console.WriteLine("A media da sala é: " + notas / numAlunos);

            Console.ReadLine();
        }
    }
}
