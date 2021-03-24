using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade.Models;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso ingresso = new Ingresso(25);
            Console.WriteLine(ingresso.ToString());

            IngressoVip ingressoVip = new IngressoVip(25, 5);
            Console.WriteLine(ingressoVip.ToString());

        }
    }
}
