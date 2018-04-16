using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfnetAT_FundCSharp
{
    class Executar 
    {
       
        List<Pessoa> pessoas = new List<Pessoa>();
        
        
        
        public void script()
        {
           
            string nome, sobrenome, escolha;
            string consultar;
            DateTime dataNascimento;



            do
            {
                Console.WriteLine("Bem vindo(a) ao gerenciador de aniversário:\n");
                Console.WriteLine("Por favor escolha uma das opções abaixo:\n1 - Inserir Dados\n2 - Consultar\n3 - Sair\n ");
                
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Console.WriteLine("Por favor insira os seguintes dados: ");
                    Console.WriteLine("");
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Sobrenome: ");
                    sobrenome= Console.ReadLine();
                    Console.WriteLine("Data de Nascimento: ");
                    dataNascimento = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.WriteLine("Os dados estão corretos?\n" + nome +" " + sobrenome +" "+ dataNascimento + "\n\n1 - Sim\n2 - Não\n");

                    escolha = Console.ReadLine();

                    if(escolha == "1")
                    {
                        Pessoa pessoa = new Pessoa(nome, sobrenome, dataNascimento);

                        pessoas.Add(pessoa); //adiciona
                        Console.WriteLine("\nEssas são as pessoas cadastradas");
                        pessoas.Sort();      //organiza as pessoas cadastradas
                        Imprimir(pessoas);
                        Console.WriteLine("");

                    }
                    else
                    {
                        Console.ReadKey();
                    }

                }
                else if (escolha == "2")
                {
                    
                    Console.WriteLine("Deseja consultar algum nome de pessoas cadastradas?"  );
                    consultar = Console.ReadLine();

                    if(consultar == "1")
                    {
                        Console.WriteLine("Por favor, digite o primeiro nome da pessoa: ");
                        nome = Console.ReadLine();

                        //Console.WriteLine("Essas são as pessoas que tem "+nome+" em seus nomes: " + pessoas.First(pessoa => pessoa.Contains(nome)));

                    }

                }
                else
                {
                    break;
                }

            } while (escolha != "3");

            Console.ReadLine();

        }

        private void Imprimir(List<Pessoa> pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }


        }

        

        /*
        void gravar()
        {
            string gravacao = @"C:\Gerenciador";
            if (File.Exists("dadosGerenciador.txt"))
            {
                Stream dados = File.Open("dadosGerenciador.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(dados);
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                   .Txt += linha;
                }
            }

        }
        */
       

    }
}
