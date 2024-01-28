using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo_quadrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo rettangolo = new Rettangolo();
            Quadrato quadrato = new Quadrato();
            rettangolo.Lato1 = int.Parse(Console.ReadLine());
            rettangolo.Lato2 = int.Parse(Console.ReadLine());
            quadrato.Lato = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1}", rettangolo.PerimetroRett(), rettangolo.AreaRett());
            Console.WriteLine("{0} {1}", quadrato.PerimetroQuad(), quadrato.AreaQuad());
            Console.WriteLine("{0}", rettangolo.ToString());
            Console.ReadLine();
        }
    }
}
