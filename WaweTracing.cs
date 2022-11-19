using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CourseWork_LeeAlgorithm
{
    internal class WaweTracing
    {
        
        public static void StartWawe(Field traceField)
        {

            if (traceField.StartM != -2 && traceField.FinishM != -2)
            {
                int d = traceField.ArrayField[traceField.StartN, traceField.StartM];
                int marksPreviousState = 0;
                int marksCurrentState = 1;
                while (traceField.ArrayField[traceField.FinishN, traceField.FinishM] == 0 && (marksCurrentState - marksPreviousState) > 0)
                {
                    marksPreviousState = marksCurrentState;
                    for (int i = 0; i < traceField.N; i++)
                    {
                        for (int j = 0; j < traceField.M; j++)
                        {
                            if (traceField.ArrayField[i, j] == d)
                            {
                                if (i != 0 && traceField.ArrayField[i - 1, j] == 0)
                                {
                                    traceField.ArrayField[i - 1, j] = d + 1;
                                    marksCurrentState++;
                                }
                                if (j != 0 && traceField.ArrayField[i, j - 1] == 0)
                                {
                                    traceField.ArrayField[i, j - 1] = d + 1;
                                    marksCurrentState++;
                                }
                                if (i != traceField.N - 1 && traceField.ArrayField[i + 1, j] == 0)
                                {
                                    traceField.ArrayField[i + 1, j] = d + 1;
                                    marksCurrentState++;
                                }
                                if (j != traceField.M - 1 && traceField.ArrayField[i, j + 1] == 0)
                                {
                                    traceField.ArrayField[i, j + 1] = d + 1;
                                    marksCurrentState++;
                                }
                            }
                        }
                    }
                    d++;
                }
            }

        }

        public static void LeadWay(Field traceField, int nCoordinate, int mCoordinate)
        {
            int d = traceField.ArrayField[nCoordinate, mCoordinate];
            if (d > 2)
            {
                if ((nCoordinate - 1 >= 0) && (d - traceField.ArrayField[nCoordinate - 1, mCoordinate]) == 1)
                {
                    var coordinates = new int[2] { nCoordinate - 1, mCoordinate };
                    traceField.Way.Insert(0, coordinates);
                    LeadWay(traceField, nCoordinate - 1, mCoordinate);
                    return;
                }
                if ((mCoordinate - 1 >= 0) && (d - traceField.ArrayField[nCoordinate, mCoordinate - 1]) == 1)
                {
                    var coordinates = new int[2] { nCoordinate, mCoordinate - 1 };
                    traceField.Way.Insert(0, coordinates);
                    LeadWay(traceField, nCoordinate, mCoordinate - 1);
                    return;
                }
                if ((traceField.N - nCoordinate > 1) && (d - traceField.ArrayField[nCoordinate + 1, mCoordinate]) == 1)
                {
                    var coordinates = new int[2] { nCoordinate + 1, mCoordinate };
                    traceField.Way.Insert(0, coordinates);
                    LeadWay(traceField, nCoordinate + 1, mCoordinate);
                    return;
                }
                if ((traceField.M - mCoordinate > 1) && (d - traceField.ArrayField[nCoordinate, mCoordinate + 1]) == 1)
                {
                    var coordinates = new int[2] { nCoordinate, mCoordinate + 1 };
                    traceField.Way.Insert(0, coordinates);
                    LeadWay(traceField, nCoordinate, mCoordinate + 1);
                    return;
                }
            } else { return; }
        }
    }
}
