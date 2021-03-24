using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Models
{
    class IngressoVip : Ingresso
    {
        
        private double valorAdicional;
       
        public virtual double ValorAdicional
        {
            get 
            { 
                return valorAdicional; 
            }
            set    
            {           
                valorAdicional = value; 
            }
        }
                                                 /*pego como referencia o valor do construtor da classe pai*/       
        public IngressoVip(double valor, double valorAdicional) : base(valor)
        { 
            this.ValorAdicional = valorAdicional;
        }

        public double SomaAdicional()
        {

            this.ValorAdicional += Valor;

            return ValorAdicional;
        }

        public override string ToString()
        {
            return $"O valor do Ingresso Vip é de: {SomaAdicional()}";
        }

    }
}
