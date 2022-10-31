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
            this.startWaweButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldPanel
            // 
            this.fieldPanel.AutoScroll = true;
            this.fieldPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fieldPanel.Location = new System.Drawing.Point(243, 15);
            this.fieldPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(933, 862);
            this.fieldPanel.TabIndex = 0;
            // 
            // initFieldButton
            // 
            this.initFieldButton.Location = new System.Drawing.Point(16, 112);
            this.initFieldButton.Margin = new System.Windows.Forms.Padding(4);
            this.initFieldButton.Name = "initFieldButton";
            this.initFieldButton.Size = new System.Drawing.Size(219, 28);
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
            this.mComboBox.Location = new System.Drawing.Point(73, 79);
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
            this.nComboBox.Location = new System.Drawing.Point(73, 46);
            this.nComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nComboBox.Name = "nComboBox";
            this.nComboBox.Size = new System.Drawing.Size(160, 24);
            this.nComboBox.TabIndex = 5;
            // 
            // startRadioButton
            // 
            this.startRadioButton.AutoSize = true;
            this.startRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.startRadioButton.Location = new System.Drawing.Point(47, 148);
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
            this.finishRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.finishRadioButton.Location = new System.Drawing.Point(47, 176);
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
            this.wallRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.wallRadioButton.Location = new System.Drawing.Point(47, 204);
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
            this.clearRadioButton.Location = new System.Drawing.Point(47, 233);
            this.clearRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearRadioButton.Name = "clearRadioButton";
            this.clearRadioButton.Size = new System.Drawing.Size(74, 20);
            this.clearRadioButton.TabIndex = 9;
            this.clearRadioButton.TabStop = true;
            this.clearRadioButton.Text = "Ластик";
            this.clearRadioButton.UseVisualStyleBackColor = true;
            // 
            // startWaweButton
            // 
            this.startWaweButton.Location = new System.Drawing.Point(16, 261);
            this.startWaweButton.Margin = new System.Windows.Forms.Padding(4);
            this.startWaweButton.Name = "startWaweButton";
            this.startWaweButton.Size = new System.Drawing.Size(219, 28);
            this.startWaweButton.TabIndex = 10;
            this.startWaweButton.Text = "Распространить волну";
            this.startWaweButton.UseVisualStyleBackColor = true;
            this.startWaweButton.Click += new System.EventHandler(this.startWaweButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Violet;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(16, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox2.Location = new System.Drawing.Point(16, 176);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(16, 204);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 233);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 804);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(219, 28);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(17, 838);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(219, 28);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 891);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startWaweButton);
            this.Controls.Add(this.clearRadioButton);
            this.Controls.Add(this.wallRadioButton);
            this.Controls.Add(this.finishRadioButton);
            this.Controls.Add(this.startRadioButton);
            this.Controls.Add(this.nComboBox);
            this.Controls.Add(this.mComboBox);
            this.Controls.Add(this.initFieldButton);
            this.Controls.Add(this.fieldPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Волновой алгоритм трассировки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button startWaweButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

