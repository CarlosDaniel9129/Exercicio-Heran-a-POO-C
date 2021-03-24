using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3.Models
{
    class Cliente
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public override string ToString()
        {
            return $"O nome do Cliente é: {Nome}\n";
        }
    }
}
