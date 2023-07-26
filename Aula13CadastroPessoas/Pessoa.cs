using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13CadastroPessoas
{
    internal class Pessoa
    {
        // ATRIBUTOS
        public string nome;
        public int idade;
        public string rua;
        public string cidade;

        // MÉTODOS
        public Pessoa( string nome, int idade, string rua, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
        }
    }
}
