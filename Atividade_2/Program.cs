using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_2.Models;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*não possui construtor*/
            Empregado daniel = new Empregado();
            daniel.Nome = "Daniel Oliveira";
            daniel.Salario = 1500;
            Console.WriteLine(daniel.ToString()); 

            Gerente rodrigo = new Gerente("Rodrigo Silva", 2500, "Vendas");
            Console.WriteLine(rodrigo.ToString());

            Vendedor carlos = new Vendedor("Carlos Daniel", 1000, 5);
            Console.WriteLine(carlos.ToString());


        }
    }
}
