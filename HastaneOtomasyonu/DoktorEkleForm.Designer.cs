namespace HastaneOtomasyonu
{
    partial class DoktorEkleForm
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
            this.btnHemsireleriGuncelle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.chlstHemsire = new System.Windows.Forms.CheckedListBox();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHemsireleriGuncelle
            // 
            this.btnHemsireleriGuncelle.Location = new System.Drawing.Point(561, 265);
            this.btnHemsireleriGuncelle.Name = "btnHemsireleriGuncelle";
            this.btnHemsireleriGuncelle.Size = new System.Drawing.Size(147, 132);
            this.btnHemsireleriGuncelle.TabIndex = 0;
            this.btnHemsireleriGuncelle.Text = "Hemsireleri Guncelle";
            this.btnHemsireleriGuncelle.UseVisualStyleBackColor = true;
            this.btnHemsireleriGuncelle.Click += new System.EventHandler(this.btnHemsireleriGuncelle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(297, 60);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(198, 22);
            this.txtAra.TabIndex = 1;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.ItemHeight = 16;
            this.lstDoktorlar.Location = new System.Drawing.Point(23, 121);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(255, 276);
            this.lstDoktorlar.TabIndex = 2;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // chlstHemsire
            // 
            this.chlstHemsire.FormattingEnabled = true;
            this.chlstHemsire.Location = new System.Drawing.Point(297, 121);
            this.chlstHemsire.Name = "chlstHemsire";
            this.chlstHemsire.Size = new System.Drawing.Size(235, 276);
            this.chlstHemsire.TabIndex = 3;
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(23, 58);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(177, 24);
            this.cmbServis.TabIndex = 4;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbServis);
            this.Controls.Add(this.chlstHemsire);
            this.Controls.Add(this.lstDoktorlar);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnHemsireleriGuncelle);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHemsireleriGuncelle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.CheckedListBox chlstHemsire;
        private System.Windows.Forms.ComboBox cmbServis;
    }
}