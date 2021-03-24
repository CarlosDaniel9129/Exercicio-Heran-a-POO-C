using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.Models
{
    class Gerente : Empregado
    {
        private string departamento;
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        
        public Gerente(string nome, double salario, string departamento)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Departamento = departamento;
        }

        public override string ToString()
        {
            return $"O nome do Gerente é: {Nome}\nSeu salário é de: {Salario}\nSeu departamento é: {Departamento}\n";
        }
    }
}
