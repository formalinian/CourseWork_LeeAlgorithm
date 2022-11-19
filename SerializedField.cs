using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseWork_LeeAlgorithm
{
    internal class SerializedField
    {
        public int N { get; set; }
        public int M { get; set; }

        public int StartN { get; set; }
        public int StartM { get; set; }

        public int FinishN { get; set; }
        public int FinishM { get; set; }

        public int[] ArrayField { get; set; }
        public int[] Way { get; set; }

        [JsonConstructor]
        public SerializedField(int N, int M, int StartN, int StartM, int FinishN, int FinishM, int[] ArrayField, int[] Way)
        {
            this.N = N;
            this.M = M;
            this.StartN = StartN;
            this.StartM = StartM;
            this.FinishN = FinishN;
            this.FinishM = FinishM;
            this.ArrayField = ArrayField;
            this.Way = Way;
        }

        public SerializedField(Field field)
        {
            this.N = field.N;
            this.M = field.M;
            this.ArrayField = new int[this.N * this.M];
            int temp = 0;
            for (int i = 0; i < this.N; i++)
            {
                for (int j = 0; j < this.M; j++)
                {
                    this.ArrayField[temp] = field.ArrayField[i, j];
                    temp++;
                }
            }
            temp = 0;
            this.StartN = field.StartN;
            this.StartM = field.StartM;
            this.FinishM = field.FinishM;
            this.FinishN = field.FinishN;
            this.Way = new int[field.Way.Count * 2];
            for (int i = 0; i < field.Way.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    this.Way[temp] = field.Way[i][j];
                    temp++;
                }
            }
        }

    }
}
