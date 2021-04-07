namespace UI
{
    partial class swlist
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
            this.dgvSwimming = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwimming)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSwimming
            // 
            this.dgvSwimming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwimming.Location = new System.Drawing.Point(0, 0);
            this.dgvSwimming.Name = "dgvSwimming";
            this.dgvSwimming.RowTemplate.Height = 24;
            this.dgvSwimming.Size = new System.Drawing.Size(1048, 684);
            this.dgvSwimming.TabIndex = 0;
            this.dgvSwimming.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // swlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 686);
            this.Controls.Add(this.dgvSwimming);
            this.Name = "swlist";
            this.Text = "swlist";
            this.Load += new System.EventHandler(this.swlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwimming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSwimming;
    }
}