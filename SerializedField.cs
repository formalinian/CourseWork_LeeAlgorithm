using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_LeeAlgorithm
{
    internal class SerializedField
    {
        public int N { get; set; }
        public int M { get; set; }

        public int startN { get; set; }
        public int startM { get; set; }

        public int finishN { get; set; }
        public int finishM { get; set; }

        public int[] arrayField { get; set; }

        public SerializedField(Field field)
        {
            this.N = field.N;
            this.M = field.M;
            this.arrayField = new int[this.N * this.M];
            int temp = 0;
            for (int i = 0; i < this.N; i++)
            {
                for (int j = 0; j < this.M; j++)
                {
                    this.arrayField[temp] = field.arrayField[i, j];
                    temp++;
                }
            }
            this.startN = field.startN;
            this.startM = field.startM;
            this.finishM = field.finishM;
            this.finishN = field.finishN;
        }
    }
}
