using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_LeeAlgorithm
{
    internal class DrawField
    {
        public static void SetMapRanges(Field traceField, System.Windows.Forms.Button[,] traceTiles)
        {
            for (int i = 0; i < traceField.N; i++)
            {
                for (int j = 0; j < traceField.M; j++)
                {
                    if (traceField.ArrayField[i, j] > 0 
                        && !(traceField.FinishN == i && traceField.FinishM == j) 
                        && !(traceField.StartN == i && traceField.StartM == j))
                    {
                        traceTiles[i, j].Text = (traceField.ArrayField[i, j] - 1).ToString();
                    }
                }
            }
        }

        public static void ClearTiles(System.Windows.Forms.Button[,] tiles, Field field)
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j].Text = " ";
                    if (field.ArrayField[i, j] > 1)
                    {
                        field.ArrayField[i, j] = 0;
                        if (!(i == field.FinishN && j == field.FinishM))
                        {
                            tiles[i, j].BackColor = Color.White;
                        }
                    }
                }
            }
        }

        public static void DrawWay(System.Windows.Forms.Button[,] tiles, Field field)
        {
            foreach (int[] coordinate in field.Way)
            {
                tiles[coordinate[0], coordinate[1]].BackColor = Color.PaleVioletRed;
            }
        }
        
    }
}
