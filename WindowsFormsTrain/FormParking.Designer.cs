namespace WindowsFormsTrain
{
    partial class FormParking
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
            this.pictureBoxParking1 = new System.Windows.Forms.PictureBox();
            this.buttonLocomotive = new System.Windows.Forms.Button();
            this.buttonElecTrain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTakeTrain = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonNewFormTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking1
            // 
            this.pictureBoxParking1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking1.Location = new System.Drawing.Point(0, 12);
            this.pictureBoxParking1.Name = "pictureBoxParking1";
            this.pictureBoxParking1.Size = new System.Drawing.Size(836, 651);
            this.pictureBoxParking1.TabIndex = 0;
            this.pictureBoxParking1.TabStop = false;
            // 
            // buttonLocomotive
            // 
            this.buttonLocomotive.Location = new System.Drawing.Point(847, 12);
            this.buttonLocomotive.Name = "buttonLocomotive";
            this.buttonLocomotive.Size = new System.Drawing.Size(109, 36);
            this.buttonLocomotive.TabIndex = 1;
            this.buttonLocomotive.Text = "Припарковать локомотив";
            this.buttonLocomotive.UseVisualStyleBackColor = true;
            this.buttonLocomotive.Click += new System.EventHandler(this.buttonSetLocomotive_Click);
            // 
            // buttonElecTrain
            // 
            this.buttonElecTrain.Location = new System.Drawing.Point(847, 54);
            this.buttonElecTrain.Name = "buttonElecTrain";
            this.buttonElecTrain.Size = new System.Drawing.Size(109, 37);
            this.buttonElecTrain.TabIndex = 2;
            this.buttonElecTrain.Text = "Припарковать электровоз";
            this.buttonElecTrain.UseVisualStyleBackColor = true;
            this.buttonElecTrain.Click += new System.EventHandler(this.buttonSetElecTrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPlace);
            this.groupBox1.Controls.Add(this.buttonTake);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(911, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 35);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(51, 54);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 6;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTakeTrain_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(51, 28);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // pictureBoxTakeTrain
            // 
            this.pictureBoxTakeTrain.Location = new System.Drawing.Point(860, 334);
            this.pictureBoxTakeTrain.Name = "pictureBoxTakeTrain";
            this.pictureBoxTakeTrain.Size = new System.Drawing.Size(240, 234);
            this.pictureBoxTakeTrain.TabIndex = 7;
            this.pictureBoxTakeTrain.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(847, 110);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonNewFormTrain
            // 
            this.buttonNewFormTrain.Location = new System.Drawing.Point(962, 12);
            this.buttonNewFormTrain.Name = "buttonNewFormTrain";
            this.buttonNewFormTrain.Size = new System.Drawing.Size(75, 23);
            this.buttonNewFormTrain.TabIndex = 9;
            this.buttonNewFormTrain.Text = "Добавить ";
            this.buttonNewFormTrain.UseVisualStyleBackColor = true;
            this.buttonNewFormTrain.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 768);
            this.Controls.Add(this.buttonNewFormTrain);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeTrain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonElecTrain);
            this.Controls.Add(this.buttonLocomotive);
            this.Controls.Add(this.pictureBoxParking1);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking1;
        private System.Windows.Forms.Button buttonLocomotive;
        private System.Windows.Forms.Button buttonElecTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.PictureBox pictureBoxTakeTrain;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonNewFormTrain;
    }
}