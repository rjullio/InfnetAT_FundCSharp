using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfnetAT_FundCSharp
{
    class Pessoa
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
        string Data { get; set; }


        List<Pessoa> pessoas = new List<Pessoa>();

        /*
        public Pessoa(string nome, string sobrenome, string data)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Data = data;
        }*/

        public void nome(string nome)
        {
            this.Nome = nome;
        }

        public void sobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public void data(string data)
        {
            this.Data = data;
        }

    }

}
