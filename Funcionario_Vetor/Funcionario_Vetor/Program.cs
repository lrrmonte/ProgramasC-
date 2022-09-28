﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] funcionario = new string[100];
            double[] salario = new double[100];
            double[] carga_horaria = new double[100];

            int i = 0;
            string nome;
            double sal;
            double horas;
            string resp = "Y";
            string opcao = "S";

            while (opcao == "S")
            {
                Console.WriteLine("\n-----------MENU------------");
                Console.WriteLine("escolha uma das opcoes: ");
                Console.WriteLine("1. cadastrar funcionarios ");
                Console.WriteLine("2. listar funcionarios ");
                Console.WriteLine("3. consultar funcionarios ");
                Console.WriteLine("4. consultar valor carga horaria ");
                Console.WriteLine("5. aumento de salario ");
                Console.WriteLine("6. remover funcionarios ");
                Console.WriteLine("7. sair ");

                int alternativa = int.Parse(Console.ReadLine());

                switch (alternativa)
                {
                    case 1:
                        for (i = 0; i < funcionario.Length; i++)
                        {
                            if (funcionario[i] == null && salario[i] == 0 && salario[i] == 0)
                            {
                                Console.Write($"digite o nome do funcionario : ");
                                nome = Console.ReadLine();
                                funcionario[i] = nome;

                                Console.Write($"digite o salario do funcionario : ");
                                sal = double.Parse(Console.ReadLine());
                                salario[i] = sal;

                                Console.Write($"digite a carga horaria do funcionario : ");
                                horas = double.Parse(Console.ReadLine());
                                carga_horaria[i] = horas;

                                break;
                            }
                        }
                        break;

                    case 2:
                        for (i = 0; i < funcionario.Length; i++)
                        {
                            if (funcionario[i] != null && salario[i] != 0 && carga_horaria[i] != 0)
                            {
                                Console.WriteLine($"\nfuncionario n.{i}: {funcionario[i]}\nsalario do funcionario{i}: {salario[i]} \ncarga horaria do funcionario{i}: {carga_horaria[i]}");
                            }
                        }
                        break;
                    case 3:

                        Console.Write("digite o numero do funcionario que deseja consultar: ");
                        int numero = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine($"\nnome do funcionario: {funcionario[numero]}\nseu salario: {salario[numero]} \nsua carga horaria: {carga_horaria[numero]}\nesta na posicao {numero}");

                        break;

                    case 4:

                        Console.WriteLine("digite o numero do funcionario que deseja consultar os valores: ");
                        numero = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine($"\nnome do funcionario: {funcionario[numero]}\nseu salario: {salario[numero]} \nsua carga horaria: {carga_horaria[numero]}\nesta na posicao {numero}");
                        do
                        {
                            Console.Write("\ndigite a informacao desejada do(a) funcionario(a) "+ funcionario[numero]+": " + "\n1.valor trabalho hora" + "\n2.trabalho dia" +
                                         "\n3.trabalho mes" + "\n4.trabalho ano");

                            int escolha = int.Parse(Console.ReadLine());

                            switch (escolha)
                            {
                                case 1:
                                    Console.WriteLine($"\nvalor trabalho hora do(a) funcionario(a) {funcionario[numero]}: R$ {Math.Round((salario[numero] / (carga_horaria[numero] * 30)), 4)}");
                                    break;
                                case 2:
                                    Console.WriteLine($"\nvalor trabalho dia do(a) funcionario(a) {funcionario[numero]}: R$ {Math.Round((salario[numero] / 30), 4)}");
                                    break;
                                case 3:
                                    Console.WriteLine($"\nvalor trabalho mês do(a) funcionario(a) {funcionario[numero]}: R$ {salario[numero]}");
                                    break;
                                case 4:
                                    Console.WriteLine($"\nvalor trabalho ano do(a) funcionario(a) {funcionario[numero]}: R$ {Math.Round((salario[numero] * 12), 4)}");
                                    break;
                                default:
                                    Console.WriteLine("\nopcao inexistente");
                                    break;
                            }
                            Console.WriteLine("digite:Y para consultar outro valor, ou qualquer tecla para sair");

                            resp = Console.ReadLine();

                        } while (resp == "Y");

                        break;

                    case 5:

                        Console.Write("digite o numero do funcionario que deseja dar aumento: ");
                        numero = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine($"\nnome do funcionario: {funcionario[numero]}\nseu salario: {salario[numero]} \nsua carga horaria: {carga_horaria[numero]}\nesta na posicao {numero}");

                        Console.WriteLine("Digite o porcentual de aumento para o funcionario: ");
                        double perc_aumento = double.Parse(Console.ReadLine());

                        double aumento = salario[numero] + (salario[numero] * (perc_aumento / 100));

                        Console.WriteLine($"\nO novo salario do funcionario {funcionario[numero]} sera: R$ {aumento}");

                        salario[numero] = aumento;

                        break;
                    case 6:

                        Console.WriteLine("digite o numero do funcionario que deseja excluir: ");
                        numero = Convert.ToInt16(Console.ReadLine());

                        funcionario[numero] = null;
                        salario[numero] = 0;
                        carga_horaria[numero] = 0;
                        Console.WriteLine("\nfuncionario(a) removido(a)");

                        break;

                    case 7:
                        opcao = "k";
                        break;
                }
            }
        }
    }
}
        
    

