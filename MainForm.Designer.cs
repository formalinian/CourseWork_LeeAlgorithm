namespace CourseWork_LeeAlgorithm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.initFieldButton = new System.Windows.Forms.Button();
            this.mComboBox = new System.Windows.Forms.ComboBox();
            this.nComboBox = new System.Windows.Forms.ComboBox();
            this.startRadioButton = new System.Windows.Forms.RadioButton();
            this.finishRadioButton = new System.Windows.Forms.RadioButton();
            this.wallRadioButton = new System.Windows.Forms.RadioButton();
            this.clearRadioButton = new System.Windows.Forms.RadioButton();
            this.findWayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldPanel
            // 
            this.fieldPanel.AutoScroll = true;
            this.fieldPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fieldPanel.Location = new System.Drawing.Point(40, 116);
            this.fieldPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(1000, 700);
            this.fieldPanel.TabIndex = 0;
            // 
            // initFieldButton
            // 
            this.initFieldButton.Location = new System.Drawing.Point(6, 59);
            this.initFieldButton.Margin = new System.Windows.Forms.Padding(4);
            this.initFieldButton.Name = "initFieldButton";
            this.initFieldButton.Size = new System.Drawing.Size(375, 28);
            this.initFieldButton.TabIndex = 3;
            this.initFieldButton.Text = "Cформировать поле";
            this.initFieldButton.UseVisualStyleBackColor = true;
            this.initFieldButton.Click += new System.EventHandler(this.initFieldButton_Click);
            // 
            // mComboBox
            // 
            this.mComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mComboBox.FormattingEnabled = true;
            this.mComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "50"});
            this.mComboBox.Location = new System.Drawing.Point(219, 25);
            this.mComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.mComboBox.Name = "mComboBox";
            this.mComboBox.Size = new System.Drawing.Size(160, 24);
            this.mComboBox.TabIndex = 4;
            // 
            // nComboBox
            // 
            this.nComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nComboBox.FormattingEnabled = true;
            this.nComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "50"});
            this.nComboBox.Location = new System.Drawing.Point(27, 25);
            this.nComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nComboBox.Name = "nComboBox";
            this.nComboBox.Size = new System.Drawing.Size(160, 24);
            this.nComboBox.TabIndex = 5;
            // 
            // startRadioButton
            // 
            this.startRadioButton.AutoSize = true;
            this.startRadioButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startRadioButton.Location = new System.Drawing.Point(40, 31);
            this.startRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.startRadioButton.Name = "startRadioButton";
            this.startRadioButton.Size = new System.Drawing.Size(67, 20);
            this.startRadioButton.TabIndex = 6;
            this.startRadioButton.TabStop = true;
            this.startRadioButton.Text = "Старт";
            this.startRadioButton.UseVisualStyleBackColor = false;
            // 
            // finishRadioButton
            // 
            this.finishRadioButton.AutoSize = true;
            this.finishRadioButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finishRadioButton.Location = new System.Drawing.Point(40, 60);
            this.finishRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.finishRadioButton.Name = "finishRadioButton";
            this.finishRadioButton.Size = new System.Drawing.Size(72, 20);
            this.finishRadioButton.TabIndex = 7;
            this.finishRadioButton.TabStop = true;
            this.finishRadioButton.Text = "Финиш";
            this.finishRadioButton.UseVisualStyleBackColor = false;
            // 
            // wallRadioButton
            // 
            this.wallRadioButton.AutoSize = true;
            this.wallRadioButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wallRadioButton.Location = new System.Drawing.Point(146, 31);
            this.wallRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.wallRadioButton.Name = "wallRadioButton";
            this.wallRadioButton.Size = new System.Drawing.Size(68, 20);
            this.wallRadioButton.TabIndex = 8;
            this.wallRadioButton.TabStop = true;
            this.wallRadioButton.Text = "Стена";
            this.wallRadioButton.UseVisualStyleBackColor = false;
            // 
            // clearRadioButton
            // 
            this.clearRadioButton.AutoSize = true;
            this.clearRadioButton.Location = new System.Drawing.Point(146, 59);
            this.clearRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearRadioButton.Name = "clearRadioButton";
            this.clearRadioButton.Size = new System.Drawing.Size(74, 20);
            this.clearRadioButton.TabIndex = 9;
            this.clearRadioButton.TabStop = true;
            this.clearRadioButton.Text = "Ластик";
            this.clearRadioButton.UseVisualStyleBackColor = true;
            // 
            // findWayButton
            // 
            this.findWayButton.Location = new System.Drawing.Point(717, 12);
            this.findWayButton.Margin = new System.Windows.Forms.Padding(4);
            this.findWayButton.Name = "findWayButton";
            this.findWayButton.Size = new System.Drawing.Size(323, 28);
            this.findWayButton.TabIndex = 10;
            this.findWayButton.Text = "Найти путь";
            this.findWayButton.UseVisualStyleBackColor = true;
            this.findWayButton.Click += new System.EventHandler(this.findWayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Violet;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(9, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox2.Location = new System.Drawing.Point(9, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(115, 30);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(115, 58);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(717, 47);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(323, 28);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(717, 81);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(323, 28);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nComboBox);
            this.panel1.Controls.Add(this.mComboBox);
            this.panel1.Controls.Add(this.initFieldButton);
            this.panel1.Location = new System.Drawing.Point(40, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 100);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "N";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки поля N x M:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.startRadioButton);
            this.panel2.Controls.Add(this.finishRadioButton);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.wallRadioButton);
            this.panel2.Controls.Add(this.clearRadioButton);
            this.panel2.Location = new System.Drawing.Point(446, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 100);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Инструменты для настройки поля:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 843);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findWayButton);
            this.Controls.Add(this.fieldPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 890);
            this.MinimumSize = new System.Drawing.Size(1100, 890);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Волновой алгоритм трассировки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fieldPanel;
        private System.Windows.Forms.Button initFieldButton;
        private System.Windows.Forms.ComboBox mComboBox;
        private System.Windows.Forms.ComboBox nComboBox;
        private System.Windows.Forms.RadioButton startRadioButton;
        private System.Windows.Forms.RadioButton finishRadioButton;
        private System.Windows.Forms.RadioButton wallRadioButton;
        private System.Windows.Forms.RadioButton clearRadioButton;
        private System.Windows.Forms.Button findWayButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}

