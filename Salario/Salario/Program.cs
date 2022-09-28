﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o nome do funcionario: ");
            string nome = (Console.ReadLine());

            Console.Write("digite o salario do funcionario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O nome do funcionario e {nome} e o seu salario e: R$ {salario}");

            Console.Write("digite a operacao desejada: " + "\n1.valor trabalho hora" + "\n2.trabalho dia" +
                "\n3.trabalho mes" + "\n4.trabalho ano");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine($"valor do trabalho hora: R$ {Math.Round((salario / 240), 4)}");
                    break;
                case 2:
                    Console.WriteLine($"valor do trabalho dia: R$ {Math.Round((salario / 30), 4)}");
                    break;
                case 3:
                    Console.WriteLine($"valor do trabalho mês: R$ {salario}");
                    break;
                case 4:
                    Console.WriteLine($"valor do trabalho ano: R$ {Math.Round((salario * 12), 4)}");
                    break;
                default:
                    Console.WriteLine("opcao inexistente");
                    break;
            }
            Console.ReadKey();
        }
    }
}
        
    