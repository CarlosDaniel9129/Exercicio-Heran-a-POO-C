using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3.Models
{
    class ContaCorrente : Cliente
    {
        protected double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public ContaCorrente(string nomeCliente, double saldo) : base(nomeCliente)
        {
            this.Cliente = nomeCliente;
            this.Saldo = saldo;
        }

        public void depositar(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine($"Você depositou o valor de: {valor}");
            Console.WriteLine($"Seu saldo atual {Saldo}");         
        }
        
        public virtual bool sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
  
                Console.WriteLine($"Seu Saque foi realizado com sucesso");
                Console.WriteLine($"Valor de tranfência: {valor}");
                Console.WriteLine($"Seu Saldo atual: {Saldo}");
                return true;
            }
            else
            {
                Console.WriteLine($"{Nome} - seu saldo é insuficiente");
                return false;
            }
            
        }
            
        public bool transferir(int conta)
        {
            if (conta == 1010)
            {
                Console.WriteLine("Transferencia realizada com sucesso \n");
                return true;
            }
            else
            {
                Console.WriteLine("Destinatário inválido");
                return false;
            }
        }

        public override string ToString()
        {
            return $"Nome do ClienteCorrente: {Cliente} - Seu Saldo: {Saldo}";
        }
    }
}
