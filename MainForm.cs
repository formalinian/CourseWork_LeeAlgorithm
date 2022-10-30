using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Text.Json;
using System.IO;

namespace CourseWork_LeeAlgorithm
{
    public partial class MainForm : Form
    {
        private Field field;
        private System.Windows.Forms.Button[,] tiles;

        public MainForm()
        {
            InitializeComponent();
        }

        private void initFieldButton_Click(object sender, EventArgs e)
        {
            fieldPanel.Controls.Clear();
            field = new Field(int.Parse(nComboBox.Text), int.Parse(mComboBox.Text));
            tiles = new System.Windows.Forms.Button[field.N, field.M];
            for (int i = 0; i < field.N; i++)
                for (int j = 0; j < field.M; j++)
                {
                    tiles[i, j] = new System.Windows.Forms.Button();
                    tiles[i, j].Location = new Point(j * 28, i * 28);
                    tiles[i, j].Size = new Size(28, 28);
                    tiles[i, j].BackColor = Color.White;
                    tiles[i, j].MouseClick += new MouseEventHandler(Tiles_Click);
                    fieldPanel.Controls.Add(tiles[i, j]);
                }
        }

        private void Tiles_Click(object sender, EventArgs e)
        {
            int iTile = 0;
            int jTile = 0;
            for (int i = 0; i < field.N; i++)
            {
                for (int j = 0; j < field.M; j++)
                {
                    if (tiles[i, j] == sender as System.Windows.Forms.Button)
                    {
                        iTile = i;
                        jTile = j;
                    }
                }
            }
                
            if (startRadioButton.Checked)
            {
                if (field.startN != -2 && field.startM != -2)
                {
                    tiles[field.startN, field.startM].BackColor = Color.White;
                    field.arrayField[field.startN, field.startM] = 0;
                }
                if (field.finishN == iTile && field.finishM == jTile)
                {
                    field.finishN = -2;
                    field.finishM = -2;
                }
                field.startN = iTile;
                field.startM = jTile;
                (sender as System.Windows.Forms.Button).BackColor = Color.Violet;
                field.arrayField[field.startN, field.startM] = 1;

            }
            if (finishRadioButton.Checked)
            {
                if (field.finishN != -2 && field.finishM != -2)
                {
                    tiles[field.finishN, field.finishM].BackColor = Color.White;
                    field.arrayField[field.finishN, field.finishM] = 0;
                }
                if (field.startN == iTile && field.startM == jTile)
                {
                    field.startN = -2;
                    field.startM = -2;
                }
                field.finishN = iTile;
                field.finishM = jTile;
                (sender as System.Windows.Forms.Button).BackColor = Color.BlueViolet;
                field.arrayField[field.finishN, field.finishM] = 0;
            }
            if (wallRadioButton.Checked)
            {
                if (field.startN == iTile && field.startM == jTile)
                {
                    field.startN = -2;
                    field.startM = -2;
                }
                if (field.finishN == iTile && field.finishM == jTile)
                {
                    field.finishN = -2;
                    field.finishM = -2;
                }
                field.arrayField[iTile, jTile] = -1;
                (sender as System.Windows.Forms.Button).BackColor = Color.Gray;
            }
            if (clearRadioButton.Checked)
            {
                if (field.startN == iTile && field.startM == jTile)
                {
                    field.startN = -2;
                    field.startM = -2;
                }
                if (field.finishN == iTile && field.finishM == jTile)
                {
                    field.finishN = -2;
                    field.finishM = -2;
                }
                field.arrayField[iTile, jTile] = 0;
                (sender as System.Windows.Forms.Button).BackColor = Color.White;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nComboBox.SelectedIndex = 0;
            mComboBox.SelectedIndex = 0;
        }

        private void startWaweButton_Click(object sender, EventArgs e)
        {
            if (field != null)
            {
                for (int i = 0; i < tiles.GetLength(0); i++)
                {
                    for (int j = 0; j < tiles.GetLength(1); j++)
                    {
                        tiles[i, j].Text = " ";
                        if (field.arrayField[i, j] > 1)
                        {
                            field.arrayField[i, j] = 0;
                            if (!(i == field.finishN && j == field.finishM))
                            {
                                tiles[i, j].BackColor = Color.White;
                            }
                        }
                    }
                }
                if (field.finishN == -2 || field.startN == -2)
                {
                    MessageBox.Show("Выставите начало и конец пути!");
                }
                else
                {
                    WaweTracing.StartWawe(field, tiles);
                    WaweTracing.LeadWay(field, tiles, field.finishN, field.finishM);
                }
            } else
            {
                MessageBox.Show("Сформируйте поле!");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (field != null)
            {
                SerializedField serializedField = new SerializedField(field);
                string json = JsonSerializer.Serialize(serializedField);
                File.WriteAllText("FieldSaveFile.json", json);
            }
        }
    }
}
