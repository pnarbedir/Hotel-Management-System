namespace UI
{
    partial class restform
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
            this.dgvRestorant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestorant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRestorant
            // 
            this.dgvRestorant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestorant.Location = new System.Drawing.Point(0, 0);
            this.dgvRestorant.Name = "dgvRestorant";
            this.dgvRestorant.RowTemplate.Height = 24;
            this.dgvRestorant.Size = new System.Drawing.Size(930, 535);
            this.dgvRestorant.TabIndex = 0;
            this.dgvRestorant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestorant_CellContentClick);
            // 
            // restform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 534);
            this.Controls.Add(this.dgvRestorant);
            this.Name = "restform";
            this.Text = "restform";
            this.Load += new System.EventHandler(this.restform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestorant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRestorant;
    }
}