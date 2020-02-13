namespace WindowsFormsTrain
{
    partial class FormTrainConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTrainConfig = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelElecTrain = new System.Windows.Forms.Label();
            this.labelLocomotive = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSecondColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Label();
            this.panelGold = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Label();
            this.panelWhite = new System.Windows.Forms.Label();
            this.panelGray = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Label();
            this.panelBlack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainConfig)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTrainConfig
            // 
            this.pictureBoxTrainConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTrainConfig.Location = new System.Drawing.Point(19, 16);
            this.pictureBoxTrainConfig.Name = "pictureBoxTrainConfig";
            this.pictureBoxTrainConfig.Size = new System.Drawing.Size(228, 117);
            this.pictureBoxTrainConfig.TabIndex = 0;
            this.pictureBoxTrainConfig.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.labelElecTrain);
            this.groupBox1.Controls.Add(this.labelLocomotive);
            this.groupBox1.Location = new System.Drawing.Point(28, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Train";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(34, 154);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // labelElecTrain
            // 
            this.labelElecTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelElecTrain.Location = new System.Drawing.Point(34, 57);
            this.labelElecTrain.Name = "labelElecTrain";
            this.labelElecTrain.Size = new System.Drawing.Size(100, 23);
            this.labelElecTrain.TabIndex = 1;
            this.labelElecTrain.Text = "ElecTrain";
            this.labelElecTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelElecTrain_MouseDown);
            // 
            // labelLocomotive
            // 
            this.labelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocomotive.Location = new System.Drawing.Point(34, 16);
            this.labelLocomotive.Name = "labelLocomotive";
            this.labelLocomotive.Size = new System.Drawing.Size(100, 23);
            this.labelLocomotive.TabIndex = 0;
            this.labelLocomotive.Text = "Locomotive";
            this.labelLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrain_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelSecondColor);
            this.panel1.Controls.Add(this.labelMainColor);
            this.panel1.Controls.Add(this.pictureBoxTrainConfig);
            this.panel1.Location = new System.Drawing.Point(256, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 228);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragEnter);
            // 
            // labelSecondColor
            // 
            this.labelSecondColor.AllowDrop = true;
            this.labelSecondColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSecondColor.Location = new System.Drawing.Point(89, 192);
            this.labelSecondColor.Name = "labelSecondColor";
            this.labelSecondColor.Size = new System.Drawing.Size(100, 23);
            this.labelSecondColor.TabIndex = 2;
            this.labelSecondColor.Text = "SecondColor";
            this.labelSecondColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelSecondColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelSecondColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(89, 153);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 23);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "MainColor";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelMainColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelGold);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(565, 54);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(166, 228);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(73, 163);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(33, 32);
            this.panelOrange.TabIndex = 7;
            this.panelOrange.Text = "label12";
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Yellow;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(73, 121);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(33, 32);
            this.panelGold.TabIndex = 6;
            this.panelGold.Text = "label11";
            this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(73, 77);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(33, 32);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.Text = "label10";
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(73, 26);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(33, 32);
            this.panelWhite.TabIndex = 4;
            this.panelWhite.Text = "label9";
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.SlateGray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(16, 163);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(33, 32);
            this.panelGray.TabIndex = 3;
            this.panelGray.Text = "label8";
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Crimson;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(16, 121);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(33, 32);
            this.panelRed.TabIndex = 2;
            this.panelRed.Text = "label7";
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(16, 77);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(33, 32);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.Text = "label6";
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(16, 26);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(33, 32);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.Text = "label5";
            this.panelBlack.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.panelBlack.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormTrainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTrainConfig";
            this.Text = "FormTrainConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainConfig)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrainConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelElecTrain;
        private System.Windows.Forms.Label labelLocomotive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSecondColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label panelOrange;
        private System.Windows.Forms.Label panelGold;
        private System.Windows.Forms.Label panelBlue;
        private System.Windows.Forms.Label panelWhite;
        private System.Windows.Forms.Label panelGray;
        private System.Windows.Forms.Label panelRed;
        private System.Windows.Forms.Label panelGreen;
        private System.Windows.Forms.Label panelBlack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}