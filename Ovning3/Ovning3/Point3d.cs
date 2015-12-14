using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class Point3D : Point
    {
        int z;

        public int GetZ()
        {
            return z;
        }

        public void SetZ(int z)
        {
            this.z = z;
        }
    }
}
