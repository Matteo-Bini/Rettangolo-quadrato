using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo_quadrato
{
    internal class Rettangolo
    {
        public int Lato1 { get; set; }
        public int Lato2 { get; set; }
        public int PerimetroRett()
        {
            return (Lato1 + Lato2)*2;
        }
        public int AreaRett()
        {
            return Lato1 * Lato2;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Lato1, Lato2);
        }
    }
}
