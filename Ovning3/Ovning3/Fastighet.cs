using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class Fastighet
    {
        public int lagenheter;
        public int hissar;
        public string gatuNamn;

        public void SetLagenheter(int lagenheter)
        {
            this.lagenheter = lagenheter;
        }

        public int GetLagenheter()
        {
            return lagenheter;
        }

        public void SetHissar(int hissar)
        {
            this.hissar = hissar;
        }

        public int GetHissar()
        {
            return hissar;
        }

        public void SetGatuNamn(string gatuNamn)
        {
            this.gatuNamn = gatuNamn;
        }

        public string GetGatuNamn()
        {
            return gatuNamn;
        }
    }
}
