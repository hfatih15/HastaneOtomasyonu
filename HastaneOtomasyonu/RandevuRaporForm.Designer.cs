namespace HastaneOtomasyonu
{
    partial class RandevuRaporForm
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
            this.cbmDoktorlar = new System.Windows.Forms.ComboBox();
            this.dgvRandevu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmDoktorlar
            // 
            this.cbmDoktorlar.FormattingEnabled = true;
            this.cbmDoktorlar.Location = new System.Drawing.Point(73, 12);
            this.cbmDoktorlar.Name = "cbmDoktorlar";
            this.cbmDoktorlar.Size = new System.Drawing.Size(121, 24);
            this.cbmDoktorlar.TabIndex = 0;
            // 
            // dgvRandevu
            // 
            this.dgvRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevu.Location = new System.Drawing.Point(73, 99);
            this.dgvRandevu.Name = "dgvRandevu";
            this.dgvRandevu.Size = new System.Drawing.Size(645, 319);
            this.dgvRandevu.TabIndex = 1;
            // 
            // RandevuRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRandevu);
            this.Controls.Add(this.cbmDoktorlar);
            this.Name = "RandevuRaporForm";
            this.Text = "RandevuRaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmDoktorlar;
        private System.Windows.Forms.DataGridView dgvRandevu;
    }
}