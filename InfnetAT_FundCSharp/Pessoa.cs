using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfnetAT_FundCSharp
{
    class Pessoa : IComparable
    {
        private string nome;
        private string sobrenome;
        private DateTime data;

        public Pessoa(string nome, string sobrenome, DateTime data)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.data = data;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public DateTime Data { get => data; set => data = value; }


        public int CompareTo(object obj)
        {
            Pessoa that = obj as Pessoa;
            return this.nome.CompareTo(that.nome);
        }

        public override string ToString()
        {
            return $"{nome} {sobrenome}, Aniversário: {data.ToString("m")}";
        }

    }

}
