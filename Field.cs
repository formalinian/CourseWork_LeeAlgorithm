using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_LeeAlgorithm
{
    internal class Field
    {
        public int N { get; set; }
        public int M { get; set; }

        public int StartN { get; set; }
        public int StartM { get; set; }

        public int FinishN { get; set; }
        public int FinishM { get; set; }

        public int[,] ArrayField { get; set; }

        public List<int[]> Way = new List<int[]>();

        public Field(int n, int m)
        {
            this.N = n;
            this.M = m; 
            this.ArrayField = new int[n,m];
            this.StartN = -2;
            this.StartM = -2;
            this.FinishM = -2;
            this.FinishN = -2;
        }
    }
}
