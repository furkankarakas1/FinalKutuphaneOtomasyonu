
namespace WindowsFormsApp1.PresantationLayer.Kullanicilar
{
    partial class KullaniciGuncelleme2
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
            this.txtKitapseri = new System.Windows.Forms.TextBox();
            this.txtid2 = new System.Windows.Forms.TextBox();
            this.btnanamenu = new System.Windows.Forms.Button();
            this.btngunelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKitapseri);
            this.panel1.Controls.Add(this.txtid2);
            this.panel1.Controls.Add(this.btnanamenu);
            this.panel1.Controls.Add(this.btngunelle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 183);
            this.panel1.TabIndex = 5;
            // 
            // txtKitapseri
            // 
            this.txtKitapseri.Location = new System.Drawing.Point(406, 64);
            this.txtKitapseri.Name = "txtKitapseri";
            this.txtKitapseri.Size = new System.Drawing.Size(216, 20);
            this.txtKitapseri.TabIndex = 2;
            // 
            // txtid2
            // 
            this.txtid2.Location = new System.Drawing.Point(106, 64);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(216, 20);
            this.txtid2.TabIndex = 2;
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
            // btngunelle
            // 
            this.btngunelle.Location = new System.Drawing.Point(698, 21);
            this.btngunelle.Name = "btngunelle";
            this.btngunelle.Size = new System.Drawing.Size(75, 23);
            this.btngunelle.TabIndex = 1;
            this.btngunelle.Text = "guncelle";
            this.btngunelle.UseVisualStyleBackColor = true;
            this.btngunelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "kitap serisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 212);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // KullaniciGuncelleme2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciGuncelleme2";
            this.Text = "KullaniciGuncelleme2";
            this.Load += new System.EventHandler(this.KullaniciGuncelleme2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKitapseri;
        private System.Windows.Forms.TextBox txtid2;
        private System.Windows.Forms.Button btnanamenu;
        private System.Windows.Forms.Button btngunelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}