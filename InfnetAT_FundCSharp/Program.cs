using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfnetAT_FundCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha, nome, sobrenome, data;

            Pessoa pessoa = new Pessoa();

            do
            {
                escolha = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao Gerenciador de Aniversários");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Adicionar nova pessoa\n2 - Pesquisar pessoas\n3 - Sair");
                Console.WriteLine("");

                Console.WriteLine("Por favor insira os seguintes dados: ");
                Console.WriteLine("");
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Sobrenome: ");
                sobrenome = " " + Console.ReadLine();
                Console.WriteLine("Data de Nascimento: ");
                data = Console.ReadLine();   //DateTime.Parse(Console.ReadLine());







            } while (escolha != "3");
 

        }
    }
}
