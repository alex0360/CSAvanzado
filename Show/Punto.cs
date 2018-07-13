using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
    //https://youtu.be/49ls_biDRog?t=3m25s
    public class Punto : IComparable<Punto>
    {
        private readonly int x;
        private readonly int y;

        public Punto(int px, int py) {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return
                string.Format("x={0}, y={1}", x, y);
        }

        //https://youtu.be/Wr7dJekGAwY
        public int CompareTo(Punto b) {
            System.Double objA = System.Math.Sqrt(x * x + y * y);
            System.Double Objb = System.Math.Sqrt(b.x * b.x + b.y * b.y);

            if (objA > Objb)
                return 1;
            if (objA < Objb)
                return -1;
            else
                return 0;
        }
    }
}
