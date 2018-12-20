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
            this.btnHemsireGuncelle = new System.Windows.Forms.Button();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.chlstHemsire = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnHemsireGuncelle
            // 
            this.btnHemsireGuncelle.Location = new System.Drawing.Point(514, 402);
            this.btnHemsireGuncelle.Name = "btnHemsireGuncelle";
            this.btnHemsireGuncelle.Size = new System.Drawing.Size(177, 23);
            this.btnHemsireGuncelle.TabIndex = 0;
            this.btnHemsireGuncelle.Text = "Hemsire Guncelle";
            this.btnHemsireGuncelle.UseVisualStyleBackColor = true;
            this.btnHemsireGuncelle.Click += new System.EventHandler(this.btnHemsireGuncelle_Click);
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(45, 91);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(121, 24);
            this.cmbServis.TabIndex = 1;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(66, 165);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 2;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.ItemHeight = 16;
            this.lstDoktorlar.Location = new System.Drawing.Point(273, 119);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(191, 260);
            this.lstDoktorlar.TabIndex = 3;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // chlstHemsire
            // 
            this.chlstHemsire.FormattingEnabled = true;
            this.chlstHemsire.Location = new System.Drawing.Point(464, 119);
            this.chlstHemsire.Name = "chlstHemsire";
            this.chlstHemsire.Size = new System.Drawing.Size(227, 259);
            this.chlstHemsire.TabIndex = 5;
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chlstHemsire);
            this.Controls.Add(this.lstDoktorlar);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.cmbServis);
            this.Controls.Add(this.btnHemsireGuncelle);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHemsireGuncelle;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.CheckedListBox chlstHemsire;
    }
}