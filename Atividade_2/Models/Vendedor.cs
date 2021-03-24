using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.Models
{
    class Vendedor : Empregado
    {
        private double percentualComissao;
        public double PercentualComissao
        {
            get { return percentualComissao; }
            set { percentualComissao = value; }
        }

       public double calcularSalario()
       {
            double salarioAcrescido;
 
            salarioAcrescido = ((Salario / 100) * PercentualComissao) + Salario;

            return salarioAcrescido;
       }

        public Vendedor(string nome, double salario, double percentualcomissao)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.PercentualComissao = percentualcomissao;
        }

        public override string ToString()
        {
            return $"Nome Vendedor: {Nome} \nSalario Médio: {Salario} \nSalario com Comissão: {calcularSalario()} \nPercentual de Comissão: {PercentualComissao}\n";
        }

    }
}
