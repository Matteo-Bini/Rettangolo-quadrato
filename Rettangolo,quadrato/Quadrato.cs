using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo_quadrato
{
    internal class Quadrato
    {
        public int Lato { get; set; }
        public int PerimetroQuad()
        { return Lato*4; }
        public int AreaQuad()
        { return Lato*Lato; }
    }
}
