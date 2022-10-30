using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Field
    {
        public int N { get ; set; }
        public int M { get; set; }

        public int startN { get; set; }
        public int startM { get; set; }

        public int finishN { get; set; }
        public int finishM { get; set; }

        public int[,] arrayField { get; set; }

        public Field(int n, int m)
        {
            this.N = n;
            this.M = m; 
            this.arrayField = new int[n,m];
            this.startN = -2;
            this.startM = -2;
            this.finishM = -2;
            this.finishN = -2;
        }
    }
}
