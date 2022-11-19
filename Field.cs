using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Field(SerializedField field)
        {
            this.N = field.N;
            this.M = field.M;
            this.StartN = field.StartN;
            this.StartM = field.StartM;
            this.FinishN = field.FinishN;
            this.FinishM = field.FinishM;
            for (int i = 0; i < field.Way.Length; i += 2)
            {
                this.Way.Add(new int[] { field.Way[i], field.Way[i + 1] });
            }
            this.ArrayField = new int[this.N, this.M];
            for (int i = 0; i < field.ArrayField.Length; i += M)
            {
                for (int j = 0; j < M; j++)
                {
                    this.ArrayField[(i / N), j] = field.ArrayField[i + j];
                }
            }
        }
    }
}
