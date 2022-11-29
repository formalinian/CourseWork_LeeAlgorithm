using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CourseWork_LeeAlgorithm
{
    internal class WaweTracing
    {

        public static void StartWawe(Field traceField)
        {
            int front = 1;
            int marksPreviousState = 0;
            int marksCurrentState = 1;
            while (traceField.ArrayField[traceField.FinishN, traceField.FinishM] == 0 && (marksCurrentState - marksPreviousState) > 0)
            {
                marksPreviousState = marksCurrentState;
                for (int i = 0; i < traceField.N; i++)
                {
                    for (int j = 0; j < traceField.M; j++)
                    {
                        if (traceField.ArrayField[i, j] == front)
                        {
                            if (i != 0 && traceField.ArrayField[i - 1, j] == 0)
                            {
                                traceField.ArrayField[i - 1, j] = front + 1;
                                marksCurrentState++;
                            }
                            if (j != traceField.M - 1 && traceField.ArrayField[i, j + 1] == 0)
                            {
                                traceField.ArrayField[i, j + 1] = front + 1;
                                marksCurrentState++;
                            }
                            if (i != traceField.N - 1 && traceField.ArrayField[i + 1, j] == 0)
                            {
                                traceField.ArrayField[i + 1, j] = front + 1;
                                marksCurrentState++;
                            }
                            if (j != 0 && traceField.ArrayField[i, j - 1] == 0)
                            {
                                traceField.ArrayField[i, j - 1] = front + 1;
                                marksCurrentState++;
                            }
                        }
                    }
                }
                front++;
            }

        }

        public static void LeadWay(Field traceField)
        {
            if (traceField.ArrayField[traceField.FinishN, traceField.FinishM] != 0)
            {
                int nCoordinate = traceField.FinishN;
                int mCoordinate = traceField.FinishM;
                int weigth = traceField.ArrayField[nCoordinate, mCoordinate];
                while (weigth > 2)
                {
                    if ((nCoordinate - 1 >= 0) && (weigth - traceField.ArrayField[nCoordinate - 1, mCoordinate]) == 1)
                    {
                        var coordinates = new int[2] { nCoordinate - 1, mCoordinate };
                        traceField.Way.Insert(0, coordinates);
                        nCoordinate = nCoordinate - 1;
                        weigth = traceField.ArrayField[nCoordinate, mCoordinate];
                        continue;
                    }
                    if ((traceField.M - mCoordinate > 1) && (weigth - traceField.ArrayField[nCoordinate, mCoordinate + 1]) == 1)
                    {
                        var coordinates = new int[2] { nCoordinate, mCoordinate + 1 };
                        traceField.Way.Insert(0, coordinates);
                        mCoordinate = mCoordinate + 1;
                        weigth = traceField.ArrayField[nCoordinate, mCoordinate];
                        continue;
                    }
                    if ((traceField.N - nCoordinate > 1) && (weigth - traceField.ArrayField[nCoordinate + 1, mCoordinate]) == 1)
                    {
                        var coordinates = new int[2] { nCoordinate + 1, mCoordinate };
                        traceField.Way.Insert(0, coordinates);
                        nCoordinate = nCoordinate + 1;
                        weigth = traceField.ArrayField[nCoordinate, mCoordinate];
                        continue;
                    }
                    if ((mCoordinate - 1 >= 0) && (weigth - traceField.ArrayField[nCoordinate, mCoordinate - 1]) == 1)
                    {
                        var coordinates = new int[2] { nCoordinate, mCoordinate - 1 };
                        traceField.Way.Insert(0, coordinates);
                        mCoordinate = mCoordinate - 1;
                        weigth = traceField.ArrayField[nCoordinate, mCoordinate];
                        continue;
                    }
                }
            }
            else { MessageBox.Show("Восстановить трассу невозможно!"); }
        }

    }
}
