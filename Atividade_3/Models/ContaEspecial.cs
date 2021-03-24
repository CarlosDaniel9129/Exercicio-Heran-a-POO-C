using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3.Models
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;

        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }

        public ContaEspecial(string nomeCliente, double saldo, double limite) : base(nomeCliente, saldo) /*pego da base = superclasse*/
        {
            this.Nome = nomeCliente;
            this.Saldo = saldo;
            this.Limite = limite;
        }

        public override bool sacar(double valor)  /*chamando método da superclasse*/
        {
            Console.WriteLine($"Saldo Anterior {Saldo}");

            if (valor <= Limite)
            {
                Saldo -= valor;
                Console.WriteLine($"Valor solicitado de saque {valor} - Saque realizado com sucesso");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
        }

        public override string ToString()
        {
            return $"O nome do ClienteEspecial: {Nome}\nSaldo Atual: {Saldo}\nLimite de Saque: {Limite}";
        }
    }
}
