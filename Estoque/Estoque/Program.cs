using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Program
    {
        private static List<Produtos> obj_prod = new List<Produtos>();
        static void Main(string[] args)
        {
            string resp = "P";

            do
            {
                Console.WriteLine("\nEscolha uma das opcão: ");
                Console.WriteLine("1. Cadastrar produto");
                Console.WriteLine("2. Listar produtos");
                Console.WriteLine("3. Sair");


                Console.WriteLine("Digite a opcao desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Qtde: ");
                        string qtde = Console.ReadLine();
                        Console.Write("Preco: ");
                        string preco = Console.ReadLine();
                        Produtos novoProd = new Produtos(nome, Convert.ToInt32(qtde), Convert.ToDouble(preco));
                        obj_prod.Add(novoProd);
                        break;

                    case 2:
                        if (obj_prod.Count > 0)
                        {
                            Console.WriteLine("\nListagem de produtos");
                            foreach (Produtos obj in obj_prod)
                            {
                                Console.WriteLine(obj.mostrarTexto());
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("nao há produtos");
                        }
                        break;

                    case 3:
                        resp = "S";
                        break;
                    default:
                        Console.WriteLine("\nOpcao invalida, tente novamente");
                        break;
                }
            } while (resp != "S");
        }
    }
}
        
    

