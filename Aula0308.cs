using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0308_manha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //const double imposto = 0.21;

            //double valor_sem_imposto;
            //valor_sem_imposto = 23.5;
            //double resultado;
            //resultado = imposto * valor_sem_imposto;
            //Console.WriteLine("valor sem imposto " + resultado);
            //Console.ReadLine();

            //Ex2
            //int a, b;
            //double soma, sub, mult, div;

            ////entrada
            //Console.Write("Insira o primeiro valor: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Insira o segundo valor: ");
            //b = int.Parse(Console.ReadLine());

            ////processamento
            //soma = a + b;
            //sub = a - b;
            //mult = a * b;
            //div = (double) a / b;

            ////Saidas
            //Console.WriteLine("A soma é: " + soma);
            //Console.WriteLine("A subtração é: " + sub);
            //Console.WriteLine("A multiplicação é: " + mult);
            //Console.WriteLine("A divisão é: " + div);

            //Exerc 3
            //int valor;
            ////double raiz;

            ////Entrada
            //Console.Write("Insira o valor: ");
            //valor = int.Parse(Console.ReadLine());

            ////Processamento


            ////Saida
            //Console.WriteLine("A raiz quadrada de " + valor + " é: " + Math.Sqrt(valor));

            //Ex 4
            //int a, b, t;

            ////Entradas
            //Console.Write("Insira o primeiro valor: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Insira o segundo valor: ");
            //b = int.Parse(Console.ReadLine()); 

            ////processamento
            ////t = a;
            ////a = b;
            ////b = t;

            ////Sem variavel auxiliar
            //a += b; //a = a + b;
            //b = a - b;
            //a -= b; //a = a - b;

            ////Saida
            //Console.WriteLine("O valor de A: " + a);
            //Console.WriteLine("O valor de B: " + b);

            //----------------------------------------------------------------------------


            //Exemplo de if
            //string sexo = "L";

            //if (sexo == "M")
            //{
            //    Console.WriteLine("Masculino!");
            //}
            //else if(sexo == "F")
            //    {
            //        Console.WriteLine("Feminino");
            //        Console.WriteLine("Passou aqui!");
            //    }
            //    else
            //    {
            //        Console.Write("OUTROS");
            //    }

            //Exemplo switch
            int categoria = 2, val = 0 ;

            switch(categoria + val)
            {
                case 1:
                    Console.WriteLine("Caiu no caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caiu no caso 2");
                    break;
                case 3:
                    Console.WriteLine("Caiu no caso 3");
                    break;
                default:
                    Console.WriteLine("Caiu no caso padrão");
                    break;
            }                       

            Console.ReadLine();
        }
    }
}
