using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1
{
    internal class WaweTracing
    {
        
        public static void StartWawe(Field traceField, System.Windows.Forms.Button[,] traceTiles)
        {

            if (traceField.startM != -2 && traceField.finishM != -2)
            {
                int d = 1;
                int previousState = 0;
                int nextState = 1;
                while (traceField.arrayField[traceField.finishN, traceField.finishM] == 0 && (nextState - previousState) > 0)
                {
                    previousState = nextState;
                    for (int i = 0; i < traceField.N; i++)
                    {
                        for (int j = 0; j < traceField.M; j++)
                        {
                            if (traceField.arrayField[i, j] == d)
                            {
                                if (i != 0 && traceField.arrayField[i - 1, j] == 0)
                                {
                                    traceField.arrayField[i - 1, j] = d + 1;
                                    nextState++;
                                    if (!((i - 1) == traceField.finishN && j == traceField.finishM))
                                    {
                                        traceTiles[i - 1, j].Text = (traceField.arrayField[i - 1, j] - 1).ToString();
                                    }
                                }
                                if (j != 0 && traceField.arrayField[i, j - 1] == 0)
                                {
                                    traceField.arrayField[i, j - 1] = d + 1;
                                    nextState++;
                                    if (!(i == traceField.finishN && (j - 1) == traceField.finishM))
                                    {
                                        traceTiles[i, j - 1].Text = (traceField.arrayField[i, j - 1] - 1).ToString();
                                    }
                                }
                                if (i != traceField.N - 1 && traceField.arrayField[i + 1, j] == 0)
                                {
                                    traceField.arrayField[i + 1, j] = d + 1;
                                    nextState++;
                                    if (!((i + 1) == traceField.finishN && j == traceField.finishM))
                                    {
                                        traceTiles[i + 1, j].Text = (traceField.arrayField[i + 1, j] - 1).ToString();
                                    }
                                }
                                if (j != traceField.M - 1 && traceField.arrayField[i, j + 1] == 0)
                                {
                                    traceField.arrayField[i, j + 1] = d + 1;
                                    nextState++;
                                    if (!(i == traceField.finishN && (j + 1) == traceField.finishM))
                                    {
                                        traceTiles[i, j + 1].Text = (traceField.arrayField[i, j + 1] - 1).ToString();
                                    }
                                }
                            }
                        }
                    }
                    d++;
                }
            }

        }

        public static void LeadWay(Field traceField, System.Windows.Forms.Button[,] traceTiles, int nCoordinate, int mCoordinate)
        {
            int d = traceField.arrayField[nCoordinate, mCoordinate];
            if (d != 2)
            {
                if ((nCoordinate - 1 >= 0) && (d - traceField.arrayField[nCoordinate - 1, mCoordinate]) == 1)
                {
                    traceTiles[nCoordinate - 1, mCoordinate].BackColor = Color.PaleVioletRed;
                    LeadWay(traceField, traceTiles, nCoordinate - 1, mCoordinate);
                    return;
                }
                if ((mCoordinate - 1 >= 0) && (d - traceField.arrayField[nCoordinate, mCoordinate - 1]) == 1)
                {
                    traceTiles[nCoordinate, mCoordinate - 1].BackColor = Color.PaleVioletRed;
                    LeadWay(traceField, traceTiles, nCoordinate, mCoordinate - 1);
                    return;
                }
                if ((traceField.N - nCoordinate > 1) && (d - traceField.arrayField[nCoordinate + 1, mCoordinate]) == 1)
                {
                    traceTiles[nCoordinate + 1, mCoordinate].BackColor = Color.PaleVioletRed;
                    LeadWay(traceField, traceTiles, nCoordinate + 1, mCoordinate);
                    return;
                }
                if ((traceField.M - mCoordinate > 1) && (d - traceField.arrayField[nCoordinate, mCoordinate + 1]) == 1)
                {
                    traceTiles[nCoordinate, mCoordinate + 1].BackColor = Color.PaleVioletRed;
                    LeadWay(traceField, traceTiles, nCoordinate, mCoordinate + 1);
                    return;
                }
            } else { return; }
        }
    }
}
