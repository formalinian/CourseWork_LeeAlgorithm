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
            openFileDialog.Filter = "Json files(*.json)|*.json";
            saveFileDialog.Filter = "Json files(*.json)|*.json";
        }

        private void initFieldButton_Click(object sender, EventArgs e)
        {
            fieldPanel.Controls.Clear();
            field = new Field(int.Parse(nComboBox.Text), int.Parse(mComboBox.Text));
            tiles = new System.Windows.Forms.Button[field.N, field.M];
            for (int i = 0; i < field.N; i++)
            {
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
                if (field.StartN != -2 && field.StartM != -2)
                {
                    tiles[field.StartN, field.StartM].BackColor = Color.White;
                    field.ArrayField[field.StartN, field.StartM] = 0;
                }
                if (field.FinishN == iTile && field.FinishM == jTile)
                {
                    field.FinishN = -2;
                    field.FinishM = -2;
                }
                field.StartN = iTile;
                field.StartM = jTile;
                (sender as System.Windows.Forms.Button).BackColor = Color.Violet;
                field.ArrayField[field.StartN, field.StartM] = 1;

            }
            if (finishRadioButton.Checked)
            {
                if (field.FinishN != -2 && field.FinishM != -2)
                {
                    tiles[field.FinishN, field.FinishM].BackColor = Color.White;
                    field.ArrayField[field.FinishN, field.FinishM] = 0;
                }
                if (field.StartN == iTile && field.StartM == jTile)
                {
                    field.StartN = -2;
                    field.StartM = -2;
                }
                field.FinishN = iTile;
                field.FinishM = jTile;
                (sender as System.Windows.Forms.Button).BackColor = Color.BlueViolet;
                field.ArrayField[field.FinishN, field.FinishM] = 0;
            }
            if (wallRadioButton.Checked)
            {
                if (field.StartN == iTile && field.StartM == jTile)
                {
                    field.StartN = -2;
                    field.StartM = -2;
                }
                if (field.FinishN == iTile && field.FinishM == jTile)
                {
                    field.FinishN = -2;
                    field.FinishM = -2;
                }
                field.ArrayField[iTile, jTile] = -1;
                (sender as System.Windows.Forms.Button).BackColor = Color.Gray;
            }
            if (clearRadioButton.Checked)
            {
                if (field.StartN == iTile && field.StartM == jTile)
                {
                    field.StartN = -2;
                    field.StartM = -2;
                }
                if (field.FinishN == iTile && field.FinishM == jTile)
                {
                    field.FinishN = -2;
                    field.FinishM = -2;
                }
                field.ArrayField[iTile, jTile] = 0;
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
                if (field.FinishN == -2 || field.StartN == -2)
                {
                    MessageBox.Show("Выставите начало и конец пути!");
                }
                else
                {
                    WaweTracing.StartWawe(field);
                    WaweTracing.LeadWay(field, field.FinishN, field.FinishM);
                }
            } else
            {
                MessageBox.Show("Сформируйте поле!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (field != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                SerializedField serializedField = new SerializedField(field);
                string json = JsonSerializer.Serialize(serializedField);
                File.WriteAllText(saveFileDialog.FileName, json);
            } else
            {
                MessageBox.Show("Сформируйте поле!");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
        }
    }
}
