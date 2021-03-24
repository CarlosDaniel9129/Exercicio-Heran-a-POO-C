using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Models
{
    class Ingresso
    {
        private double valor;
   
        public double Valor
        {
            get 
            { 
                return valor; 
            }
            set { valor = value; }
        }


        public Ingresso(double valor)
        {
             this.Valor = valor;
        }

        public override string ToString()
        {
            /*pego o retorno do Valor do meu objeto e passo no ToString para me retornar somente o valor em fomra de Stirng*/
            return $"{Valor}";
        }

    }
}
