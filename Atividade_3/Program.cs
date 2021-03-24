using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_3.Models;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente carlos = new Cliente("Carlos Daniel");
            Console.WriteLine(carlos.ToString());
            Console.WriteLine("------------------------------------------------");

            ContaCorrente daniel = new ContaCorrente("Daniel Oliveira", 5000);
            Console.WriteLine(daniel.ToString()); 
            daniel.depositar(5000);
            daniel.sacar(2000);
            daniel.transferir(1010); /*para a verificação ser true, a conta deve ser 1010*/
            Console.WriteLine("------------------------------------------------");

            ContaEspecial rodrigo = new ContaEspecial("Rodrigo Carlos", 10000, 15000);
            rodrigo.sacar(12000);
            Console.WriteLine(rodrigo.ToString());
           
             
        }
    }
}
