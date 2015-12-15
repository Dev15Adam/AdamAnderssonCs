using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class Lagenheter
    {
        public Fastighet ytterdorrar;
        public int fonster;

        public void SetYtterDorrar(Fastighet y)
        {
            this.ytterdorrar = y;
        }

        public Fastighet GetYtterDorrar()
        {
            return ytterdorrar;
        }

        public void SetFonster(int fonster)
        {
            this.fonster = fonster;
        }

        public int GetFonster()
        {
            return fonster;
        }
    }
}
