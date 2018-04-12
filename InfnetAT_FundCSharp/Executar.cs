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
        Pessoa pessoa = new Pessoa();

        
        int contador = 0;
        private StreamReader leitor;

        public void parabens()
        {
            DateTime agora = DateTime.Now;
   
        }


        public void script()
        {
            
            string escolha;

            do
            {
                

                escolha = Console.ReadLine();

                Console.WriteLine("");

                if (escolha == "1")
                {
                    Console.WriteLine("Por favor insira os seguintes dados: ");
                    Console.WriteLine("");
                    Console.WriteLine("Nome: ");
                    pessoa.nome = Console.ReadLine();
                    Console.WriteLine("Sobrenome: ");
                    c.Sobrenome = " " + Console.ReadLine();
                    Console.WriteLine("Data de Nascimento: ");
                    c.Data =  DateTime.Parse( Console.ReadLine());


                    Console.WriteLine(" ");
                    Console.WriteLine("Os dados estão corretos?\n" + c.Nome + c.Sobrenome + c.Data + "\n\n1 - Sim\n2 - Não\n");

                    escolha = Console.ReadLine();

                    if(escolha == "1")
                    {
                        vetor_clientes[contador] = c;
                        
                        if(contador < vetor_clientes.Length)
                        {
                            contador++;
                        }

                        else
                        {
                            Console.WriteLine("O gerenciador está cheio");
                        }

                    }
                    else
                    {
                        Console.ReadKey();
                    }

                }
                else if (escolha == "2")
                {

                }

            } while (escolha != "3");

            Console.ReadLine();
        }

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

        void consulta(Cliente consultar)
        {
            for (int i = 0; i < vetor_clientes.Length; i++)
            {
                   
            }

        }

       
    }
}
