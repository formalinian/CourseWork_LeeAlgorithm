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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.initFieldButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.fieldPanel.Location = new System.Drawing.Point(182, 12);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(700, 700);
            this.fieldPanel.TabIndex = 0;
            // 
            // initFieldButton
            // 
            this.initFieldButton.Location = new System.Drawing.Point(12, 91);
            this.initFieldButton.Name = "initFieldButton";
            this.initFieldButton.Size = new System.Drawing.Size(164, 23);
            this.initFieldButton.TabIndex = 3;
            this.initFieldButton.Text = "Cформировать поле";
            this.initFieldButton.UseVisualStyleBackColor = true;
            this.initFieldButton.Click += new System.EventHandler(this.initFieldButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.mComboBox.Location = new System.Drawing.Point(55, 64);
            this.mComboBox.Name = "mComboBox";
            this.mComboBox.Size = new System.Drawing.Size(121, 21);
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
            this.nComboBox.Location = new System.Drawing.Point(55, 37);
            this.nComboBox.Name = "nComboBox";
            this.nComboBox.Size = new System.Drawing.Size(121, 21);
            this.nComboBox.TabIndex = 5;
            // 
            // startRadioButton
            // 
            this.startRadioButton.AutoSize = true;
            this.startRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.startRadioButton.Location = new System.Drawing.Point(35, 120);
            this.startRadioButton.Name = "startRadioButton";
            this.startRadioButton.Size = new System.Drawing.Size(54, 17);
            this.startRadioButton.TabIndex = 6;
            this.startRadioButton.TabStop = true;
            this.startRadioButton.Text = "Старт";
            this.startRadioButton.UseVisualStyleBackColor = false;
            // 
            // finishRadioButton
            // 
            this.finishRadioButton.AutoSize = true;
            this.finishRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.finishRadioButton.Location = new System.Drawing.Point(35, 143);
            this.finishRadioButton.Name = "finishRadioButton";
            this.finishRadioButton.Size = new System.Drawing.Size(62, 17);
            this.finishRadioButton.TabIndex = 7;
            this.finishRadioButton.TabStop = true;
            this.finishRadioButton.Text = "Финиш";
            this.finishRadioButton.UseVisualStyleBackColor = false;
            // 
            // wallRadioButton
            // 
            this.wallRadioButton.AutoSize = true;
            this.wallRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.wallRadioButton.Location = new System.Drawing.Point(35, 166);
            this.wallRadioButton.Name = "wallRadioButton";
            this.wallRadioButton.Size = new System.Drawing.Size(55, 17);
            this.wallRadioButton.TabIndex = 8;
            this.wallRadioButton.TabStop = true;
            this.wallRadioButton.Text = "Стена";
            this.wallRadioButton.UseVisualStyleBackColor = false;
            // 
            // clearRadioButton
            // 
            this.clearRadioButton.AutoSize = true;
            this.clearRadioButton.Location = new System.Drawing.Point(35, 189);
            this.clearRadioButton.Name = "clearRadioButton";
            this.clearRadioButton.Size = new System.Drawing.Size(62, 17);
            this.clearRadioButton.TabIndex = 9;
            this.clearRadioButton.TabStop = true;
            this.clearRadioButton.Text = "Ластик";
            this.clearRadioButton.UseVisualStyleBackColor = true;
            // 
            // startWaweButton
            // 
            this.startWaweButton.Location = new System.Drawing.Point(12, 212);
            this.startWaweButton.Name = "startWaweButton";
            this.startWaweButton.Size = new System.Drawing.Size(164, 23);
            this.startWaweButton.TabIndex = 10;
            this.startWaweButton.Text = "Распространить волну";
            this.startWaweButton.UseVisualStyleBackColor = true;
            this.startWaweButton.Click += new System.EventHandler(this.startWaweButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Violet;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox2.Location = new System.Drawing.Point(12, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(12, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 724);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
    }
}

