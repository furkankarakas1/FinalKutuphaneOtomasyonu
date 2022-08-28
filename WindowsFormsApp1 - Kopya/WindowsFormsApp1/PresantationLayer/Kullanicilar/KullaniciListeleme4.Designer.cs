
namespace WindowsFormsApp1.PresantationLayer.Kullanicilar
{
    partial class KullaniciListeleme4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKAd = new System.Windows.Forms.CheckBox();
            this.cbKullaniciAdi = new System.Windows.Forms.CheckBox();
            this.RbSeçilen = new System.Windows.Forms.RadioButton();
            this.rbTümListe = new System.Windows.Forms.RadioButton();
            this.btnanamenu = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbKAd);
            this.panel1.Controls.Add(this.cbKullaniciAdi);
            this.panel1.Controls.Add(this.RbSeçilen);
            this.panel1.Controls.Add(this.rbTümListe);
            this.panel1.Controls.Add(this.btnanamenu);
            this.panel1.Controls.Add(this.btnListe);
            this.panel1.Location = new System.Drawing.Point(12, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 183);
            this.panel1.TabIndex = 13;
            // 
            // cbKAd
            // 
            this.cbKAd.AutoSize = true;
            this.cbKAd.Location = new System.Drawing.Point(147, 95);
            this.cbKAd.Name = "cbKAd";
            this.cbKAd.Size = new System.Drawing.Size(76, 17);
            this.cbKAd.TabIndex = 3;
            this.cbKAd.Text = "yayin serisi";
            this.cbKAd.UseVisualStyleBackColor = true;
            // 
            // cbKullaniciAdi
            // 
            this.cbKullaniciAdi.AutoSize = true;
            this.cbKullaniciAdi.Location = new System.Drawing.Point(147, 52);
            this.cbKullaniciAdi.Name = "cbKullaniciAdi";
            this.cbKullaniciAdi.Size = new System.Drawing.Size(60, 17);
            this.cbKullaniciAdi.TabIndex = 3;
            this.cbKullaniciAdi.Text = "kitap id";
            this.cbKullaniciAdi.UseVisualStyleBackColor = true;
            // 
            // RbSeçilen
            // 
            this.RbSeçilen.AutoSize = true;
            this.RbSeçilen.Location = new System.Drawing.Point(26, 48);
            this.RbSeçilen.Name = "RbSeçilen";
            this.RbSeçilen.Size = new System.Drawing.Size(112, 17);
            this.RbSeçilen.TabIndex = 2;
            this.RbSeçilen.TabStop = true;
            this.RbSeçilen.Text = "seciliAlanlarıListele";
            this.RbSeçilen.UseVisualStyleBackColor = true;
            this.RbSeçilen.CheckedChanged += new System.EventHandler(this.RbSeçilen_CheckedChanged);
            // 
            // rbTümListe
            // 
            this.rbTümListe.AutoSize = true;
            this.rbTümListe.Location = new System.Drawing.Point(26, 21);
            this.rbTümListe.Name = "rbTümListe";
            this.rbTümListe.Size = new System.Drawing.Size(106, 17);
            this.rbTümListe.TabIndex = 2;
            this.rbTümListe.TabStop = true;
            this.rbTümListe.Text = "tümAlanlarıListele";
            this.rbTümListe.UseVisualStyleBackColor = true;
            this.rbTümListe.CheckedChanged += new System.EventHandler(this.rbTümListe_CheckedChanged);
            // 
            // btnanamenu
            // 
            this.btnanamenu.Location = new System.Drawing.Point(701, 64);
            this.btnanamenu.Name = "btnanamenu";
            this.btnanamenu.Size = new System.Drawing.Size(75, 23);
            this.btnanamenu.TabIndex = 1;
            this.btnanamenu.Text = "a.menu";
            this.btnanamenu.UseVisualStyleBackColor = true;
            this.btnanamenu.Click += new System.EventHandler(this.btnanamenu_Click);
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(698, 21);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 23);
            this.btnListe.TabIndex = 1;
            this.btnListe.Text = "listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 212);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // KullaniciListeleme4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "KullaniciListeleme4";
            this.Text = "KullaniciListeleme4";
            this.Load += new System.EventHandler(this.KullaniciListeleme4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbKAd;
        private System.Windows.Forms.CheckBox cbKullaniciAdi;
        private System.Windows.Forms.RadioButton RbSeçilen;
        private System.Windows.Forms.RadioButton rbTümListe;
        private System.Windows.Forms.Button btnanamenu;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}