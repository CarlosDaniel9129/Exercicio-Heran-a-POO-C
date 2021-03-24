using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.Models
{
    class Empregado
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public override string ToString()
        {
            return $"O nome do Empregado é: {Nome}\nO salário é de R$: {Salario}\n";
        }

    }
}
