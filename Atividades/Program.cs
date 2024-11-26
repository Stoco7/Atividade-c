using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 01");

            int n1 = 0;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 == 0 )
            {
                Console.WriteLine("Seu numero é igual a 0");
            }
            else if (n1 >= 1)
            {
                Console.WriteLine("Seu número é Positivo");
            }
            else
            {
                Console.WriteLine("Seu número é Negativo");
            }



            Console.WriteLine("Atividade 02");

            int mes = 0;

            Console.Write("Escolha um Mes para saber quantos dias ele tem: ");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Este mes tem 30 dias");
            }
            else
            {
                Console.WriteLine("Este mes tem 28 dias");
            }



            Console.WriteLine("Atividade 03");

            int nota = 0;

            Console.Write("Informe sua Nota: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Voce foi aprovado");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Voce esta de recuperação");
            }
            else
            {
                Console.WriteLine("Voce foi reprovado");
            }



            Console.WriteLine("Atividade 04");

            int nums = 0;
            for (int i = 0; i <= 100; i++)
            {
                nums = i + nums;
                Console.WriteLine(nums);
            }

            Console.WriteLine("Atividade 05");

            for (int j = 10;j >= 0; j--)
            {
                Console.WriteLine(j);
            }



            Console.WriteLine("Atividade 06");

            string nome = "";
            Console.Write("Qual o seu nome: ");
            nome = Console.ReadLine();

            float nota1 = 0;
            Console.Write("Informe a Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            float nota2 = 0;
            Console.Write("Informe a Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            float nota3 = 0;
            Console.Write("Informe a Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A média de suas notas é " + media);

            if (media >= 7)
            {
                Console.WriteLine("Voce foi aprovado");
            }
            else
            {
                Console.WriteLine("Voce foi reprovado");
            }

        }
    }
}
