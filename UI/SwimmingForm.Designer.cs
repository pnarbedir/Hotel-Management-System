namespace UI
{
    partial class SwimmingForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.alphaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.havuz1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel1.Border = true;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.Controls.Add(this.textNumber);
            this.alphaGradientPanel1.Controls.Add(this.label2);
            this.alphaGradientPanel1.Controls.Add(this.label3);
            this.alphaGradientPanel1.Controls.Add(this.button1);
            this.alphaGradientPanel1.Controls.Add(this.comboBoxTime);
            this.alphaGradientPanel1.Controls.Add(this.comboBoxDay);
            this.alphaGradientPanel1.Controls.Add(this.textSurname);
            this.alphaGradientPanel1.Controls.Add(this.textName);
            this.alphaGradientPanel1.Controls.Add(this.label1);
            this.alphaGradientPanel1.CornerRadius = 20;
            this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel1.Gradient = true;
            this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel1.GradientOffset = 1F;
            this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel1.Grayscale = false;
            this.alphaGradientPanel1.Image = null;
            this.alphaGradientPanel1.ImageAlpha = 75;
            this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel1.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
            this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel1.Location = new System.Drawing.Point(65, 52);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = true;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(465, 403);
            this.alphaGradientPanel1.TabIndex = 1;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "07.00-09.30",
            "10.00-12.30",
            "13.30-16.00",
            "17.00-19.30",
            "20.00-22.30"});
            this.comboBoxTime.Location = new System.Drawing.Point(217, 246);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(186, 33);
            this.comboBoxTime.TabIndex = 5;
            this.comboBoxTime.Text = "Choose The Time";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxDay.Location = new System.Drawing.Point(12, 246);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(182, 33);
            this.comboBoxDay.TabIndex = 4;
            this.comboBoxDay.Text = "Choose The Day";
            // 
            // textSurname
            // 
            this.textSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSurname.Location = new System.Drawing.Point(169, 120);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(244, 28);
            this.textSurname.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textName.Location = new System.Drawing.Point(169, 58);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(244, 28);
            this.textName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(126, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number:";
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNumber.Location = new System.Drawing.Point(169, 187);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(244, 28);
            this.textNumber.TabIndex = 8;
            // 
            // SwimmingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 578);
            this.Controls.Add(this.alphaGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SwimmingForm";
            this.Text = "SwimmingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.alphaGradientPanel1.ResumeLayout(false);
            this.alphaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}