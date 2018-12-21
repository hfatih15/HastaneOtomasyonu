namespace HastaneOtomasyonu
{
    partial class RandevuForm
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(878, 316);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 84);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.ItemHeight = 16;
            this.lstHastalar.Location = new System.Drawing.Point(12, 107);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(223, 276);
            this.lstHastalar.TabIndex = 1;
            this.lstHastalar.SelectedIndexChanged += new System.EventHandler(this.lstHastalar_SelectedIndexChanged);
            this.lstHastalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstHastalar_KeyDown);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(41, 26);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 2;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(409, 14);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(121, 24);
            this.cmbServis.TabIndex = 3;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(213, 24);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 24);
            this.cmbDoktor.TabIndex = 4;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // flpSaatler
            // 
            this.flpSaatler.Location = new System.Drawing.Point(254, 54);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(573, 547);
            this.flpSaatler.TabIndex = 5;
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 613);
            this.Controls.Add(this.flpSaatler);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbServis);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstHastalar);
            this.Controls.Add(this.btnKaydet);
            this.Name = "RandevuForm";
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.FlowLayoutPanel flpSaatler;
    }
}