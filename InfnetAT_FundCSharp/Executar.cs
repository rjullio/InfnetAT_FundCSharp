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
        private string ficheiro;

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
                    Console.WriteLine("Os dados estão corretos?\n" + nome +" " + sobrenome +" "+ dataNascimento.ToString("m") + "\n\n1 - Sim\n2 - Não\n");

                    escolha = Console.ReadLine();

                    if(escolha == "1")
                    {
                        Pessoa pessoa = new Pessoa(nome, sobrenome, dataNascimento);

                        pessoas.Add(pessoa); //adiciona
                        Console.WriteLine("\nEssas são as pessoas cadastradas\n");
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
                    Console.WriteLine("Digite o nome da pessoa a ser procurado"  );
                    nome = Console.ReadLine();                    
                    Consultar(nome);                    
                }
                else
                {
                    Gravar(pessoas);
                    break;
                }

            } while (escolha != "3");

            Console.ReadLine();

        }

        private void Gravar(List<Pessoa> pessoas)
        {
            string ficheiro = @"c:\\temp\\pessoaani.txt";

            if (File.Exists(ficheiro) == true) // verifica se o ficheiro existe
            {
                StreamReader sr;
                sr = File.OpenText(ficheiro);// abre o ficheiro para leitura
                string[] campos = new string[3];
                string linha = "";
                campos = linha.Split(';');
                if (DateTime.Parse(campos[2]).Day == DateTime.Now.Day && DateTime.Parse(campos[2]).Month == DateTime.Now.Month)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", campos[0], campos[1], campos[2]);
                }
                else
                {
                    Console.WriteLine("não existe aniversario a exibir");
                }
                sr.Close();
            }
        }
       

        private void Consultar(String nome)
        {            
            Console.WriteLine("Pessoas de nome: " + nome + 
                " cadastradas: " + pessoas.First(pessoa => nome.Contains(nome)));
        }
        


        private void Imprimir(List<Pessoa> pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }


        }

        private void CalcularAniverario(DateTime data)
        {

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
