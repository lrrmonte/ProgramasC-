using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("digite o salario do funcionario: ");
            double salario = double.Parse(Console.ReadLine());

            string opcao = "1";

            while (opcao != "0")
            {
                Console.WriteLine("Escolha uma das opcoes: " + "\n1.valor trabalho hora" + "\n2.valor trabalho dia" +
                        "\n3.valor trabalho mes" + "\n4.valor trabalho ano");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine($"valor trabalho hora: R${hora(salario)}");
                        break;
                    case 2:
                        Console.WriteLine($"valor trabalho dia: R${dia(salario)}");
                        break;
                    case 3:
                        Console.WriteLine($"valor trabalho mes: R${mes(salario)}");
                        break;
                    case 4:
                        Console.WriteLine($"valor trabalho ano: R${ano(salario)}");
                        break;
                }
                Console.WriteLine("digite 0 para sair ou qualquer outra tecla para continuar");

                opcao = (Console.ReadLine());
            }
            Console.WriteLine("continua");
        }
        static double hora(double sal)
        {
            return Math.Round((sal / 240), 4);
        }
        static double dia(double sal)
        {
            return Math.Round((sal / 30), 4);
        }
        static double mes(double sal)
        {
            return Math.Round(sal);
        }
        static double ano(double sal)
        {
            return Math.Round((sal * 12), 4);
        }
    }
}
        
    

