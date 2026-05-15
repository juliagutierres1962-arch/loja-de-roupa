using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace geh5strapped
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 5) // !=diferente
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
░██████╗░███████╗██╗░░██╗███████╗░██████╗████████╗██████╗░░█████╗░██████╗░██████╗░███████╗██████╗░
██╔════╝░██╔════╝██║░░██║██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗
██║░░██╗░█████╗░░███████║██████╗░╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝██████╔╝█████╗░░██║░░██║
██║░░╚██╗██╔══╝░░██╔══██║╚════██╗░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔═══╝░██╔═══╝░██╔══╝░░██║░░██║
╚██████╔╝███████╗██║░░██║██████╔╝██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░░░░██║░░░░░███████╗██████╔╝
░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░╚══════╝╚═════╝░");
                Console.ResetColor();
                Console.WriteLine("\n 1 - fornecedores");
                Console.WriteLine("\n 2- funcionarios");
                Console.WriteLine("\n 3- clientes");
                Console.WriteLine("\n 4- produtos");
                Console.WriteLine("\n 5- sair");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("digite a opcao escolhida");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        fornecedores();
                        break;
                    case 2:
                        funcionarios();
                        break;
                    case 3:
                        clientes();
                        break;
                    case 4:
                        produtos();
                        break;
                    case 5:

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(@"
░█████╗░██████╗░██████╗░██╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝░██╔══██╗██╔══██╗██╔══██╗
██║░░██║██████╦╝██████╔╝██║██║░░██╗░███████║██║░░██║███████║
██║░░██║██╔══██╗██╔══██╗██║██║░░╚██╗██╔══██║██║░░██║██╔══██║
╚█████╔╝██████╦╝██║░░██║██║╚██████╔╝██║░░██║██████╔╝██║░░██║
░╚════╝░╚═════╝░╚═╝░░╚═╝╚═╝░╚═════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝");
                        Console.ResetColor();
                        Thread.Sleep(2000); // pausa na programação por 2s

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("opção invalida!!");
                        Console.ResetColor();
                        Thread.Sleep(2000); // pausa na programação por 2s


                        break;
                }

            }

        }
        static void fornecedores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░███████╗░██████╗
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝█████╗░░╚█████╗░
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗██╔══╝░░░╚═══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║███████╗██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░");
           
            Console.ResetColor();
            Console.WriteLine("\n nome do fornecedor");
            string nomefornecedor = Console.ReadLine();
            Console.WriteLine("\n cnpj do fornecedor");
            string cnpjfornecedor = Console.ReadLine();
            Console.WriteLine("\n data de nasc do fornecedor");
            string datadenasc = Console.ReadLine();
            Console.WriteLine("\n endereço do fornecedor");
            string endereço = Console.ReadLine();
            Console.WriteLine("\n telefone do fornecedor");
            string telefone = Console.ReadLine();

            Console.WriteLine("fornecedor cadastrado");
            Thread.Sleep(2000); // pausa na programação por 2s
        }
             
            static void funcionarios()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██████╗░██╗░█████╗░░██████╗
██╔════╝██║░░░██║████╗░██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██╔══██╗██║██╔══██╗██╔════╝
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██████╔╝██║██║░░██║╚█████╗░
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██║██║░░██║██║╚████║██╔══██║██╔══██╗██║██║░░██║░╚═══██╗
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░░██║██║╚█████╔╝██████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n qual o nome do funcionario?:");
                string nomefuncionario = Console.ReadLine();
                Console.WriteLine("\n cpf do funcionario");
                string cpffuncionario = Console.ReadLine();
                Console.WriteLine("\n data de nasc do funcionario");
                string datadenasc = Console.ReadLine();
                Console.WriteLine("endereço do funcionario");
                string endereco = Console.ReadLine();
                Console.WriteLine("\n telefone do funcionario");
                string telefone = Console.ReadLine();
                Console.WriteLine("qual a função do funcionario?");
                string funcao = Console.ReadLine();


                Console.WriteLine("funcionario cadastrado");
                Thread.Sleep(2000); // pausa na programação por 2s
            }

        static void clientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n qual o nome do cliente?");
            string nomecliente = Console.ReadLine();
            Console.WriteLine("cpf do cliente");
            string cpfcliente = Console.ReadLine();
            Console.WriteLine("data de nasc do cliente");
            string datadenasc = Console.ReadLine();
            Console.WriteLine("endereço do cliente");
            string endereco = Console.ReadLine();
            Console.WriteLine("telefone do cliente");
            string telefone = Console.ReadLine();

            Console.WriteLine("cliente cadastrado");
            Thread.Sleep(2000); // pausa na programação por 2s

        }

        static void produtos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗████████╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║╚══██╔══╝██╔══██╗██╔════╝
██████╔╝██████╔╝██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║╚█████╗░
██╔═══╝░██╔══██╗██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║░╚═══██╗
██║░░░░░██║░░██║╚█████╔╝██████╔╝╚██████╔╝░░░██║░░░╚█████╔╝██████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═════╝░░╚═════╝░░░░╚═╝░░░░╚════╝░╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n qual o nome do produto?");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("\n categoria do produto");
            string categoriaroupa = Console.ReadLine();
            Console.WriteLine("\n peso do produto");
            string pesoproduto = Console.ReadLine();
            Console.WriteLine("valor do produto");
            string valorproduto = Console.ReadLine();

            Thread.Sleep(2000); // pausa na programação por 2s
        }
        

       


           

        
    }

}
                



            
        
    

