namespace UI
{
    partial class ReservationForm
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
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dtpArrived = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textEposta = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alphaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel1.Border = true;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.Controls.Add(this.button1);
            this.alphaGradientPanel1.Controls.Add(this.textID);
            this.alphaGradientPanel1.Controls.Add(this.dtpReturn);
            this.alphaGradientPanel1.Controls.Add(this.textBox6);
            this.alphaGradientPanel1.Controls.Add(this.textBox5);
            this.alphaGradientPanel1.Controls.Add(this.dtpArrived);
            this.alphaGradientPanel1.Controls.Add(this.comboBoxRoom);
            this.alphaGradientPanel1.Controls.Add(this.checkBox3);
            this.alphaGradientPanel1.Controls.Add(this.checkBox2);
            this.alphaGradientPanel1.Controls.Add(this.checkBox1);
            this.alphaGradientPanel1.Controls.Add(this.textNumber);
            this.alphaGradientPanel1.Controls.Add(this.textEposta);
            this.alphaGradientPanel1.Controls.Add(this.textSurname);
            this.alphaGradientPanel1.Controls.Add(this.textName);
            this.alphaGradientPanel1.Controls.Add(this.comboBoxCity);
            this.alphaGradientPanel1.CornerRadius = 20;
            this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alphaGradientPanel1.Gradient = true;
            this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.alphaGradientPanel1.GradientOffset = 1F;
            this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel1.Grayscale = false;
            this.alphaGradientPanel1.Image = null;
            this.alphaGradientPanel1.ImageAlpha = 75;
            this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel1.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
            this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel1.Location = new System.Drawing.Point(418, 12);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = true;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(419, 539);
            this.alphaGradientPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(146, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textID
            // 
            this.textID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textID.Location = new System.Drawing.Point(15, 113);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(318, 28);
            this.textID.TabIndex = 12;
            this.textID.Text = "İdentity Number";
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "yyyy-MM-dd";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(175, 457);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(234, 28);
            this.dtpReturn.TabIndex = 2;
            this.dtpReturn.Value = new System.DateTime(2019, 5, 21, 0, 0, 0, 0);
            this.dtpReturn.ValueChanged += new System.EventHandler(this.dtpReturn_ValueChanged);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox6.Location = new System.Drawing.Point(15, 457);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 28);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Date Of Return";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox5.Location = new System.Drawing.Point(15, 410);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 28);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Date Of Arrived";
            // 
            // dtpArrived
            // 
            this.dtpArrived.CustomFormat = "yyyy-MM-dd";
            this.dtpArrived.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrived.Location = new System.Drawing.Point(175, 410);
            this.dtpArrived.Name = "dtpArrived";
            this.dtpArrived.Size = new System.Drawing.Size(234, 28);
            this.dtpArrived.TabIndex = 2;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.comboBoxRoom.Location = new System.Drawing.Point(15, 362);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(236, 30);
            this.comboBoxRoom.TabIndex = 3;
            this.comboBoxRoom.Text = "Please Select Room..";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox3.Location = new System.Drawing.Point(15, 310);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(221, 28);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Baby(smaller than two)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox2.Location = new System.Drawing.Point(126, 257);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(274, 28);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Children(smaller than twelve)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.Location = new System.Drawing.Point(15, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 28);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Adult";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textNumber
            // 
            this.textNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNumber.Location = new System.Drawing.Point(15, 213);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(236, 28);
            this.textNumber.TabIndex = 6;
            this.textNumber.Text = "Phone Number";
            this.textNumber.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textEposta
            // 
            this.textEposta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEposta.Location = new System.Drawing.Point(15, 162);
            this.textEposta.Name = "textEposta";
            this.textEposta.Size = new System.Drawing.Size(318, 28);
            this.textEposta.TabIndex = 5;
            this.textEposta.Text = "E-posta";
            // 
            // textSurname
            // 
            this.textSurname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSurname.Location = new System.Drawing.Point(175, 67);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(143, 28);
            this.textSurname.TabIndex = 4;
            this.textSurname.Text = "Your Surname";
            // 
            // textName
            // 
            this.textName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textName.Location = new System.Drawing.Point(15, 67);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(143, 28);
            this.textName.TabIndex = 3;
            this.textName.Text = "Your Name";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "İstanbul",
            "Çanakkale",
            "İzmir",
            "Muğla",
            "Antalya"});
            this.comboBoxCity.Location = new System.Drawing.Point(15, 17);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(236, 30);
            this.comboBoxCity.TabIndex = 2;
            this.comboBoxCity.Text = "Please Select Province.. ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.rezervasyon_back;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 552);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 563);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.alphaGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.alphaGradientPanel1.ResumeLayout(false);
            this.alphaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textEposta;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpArrived;
    }
}