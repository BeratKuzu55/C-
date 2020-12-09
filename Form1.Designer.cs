namespace NetFramework.Sıra19.D7.ComboBoxİnceleme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxÜrünListe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxÜrünAçıklama = new System.Windows.Forms.RichTextBox();
            this.textBoxStokAdedi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxÜrünAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ürün listesi";
            // 
            // comboBoxÜrünListe
            // 
            this.comboBoxÜrünListe.FormattingEnabled = true;
            this.comboBoxÜrünListe.Location = new System.Drawing.Point(73, 3);
            this.comboBoxÜrünListe.Name = "comboBoxÜrünListe";
            this.comboBoxÜrünListe.Size = new System.Drawing.Size(370, 21);
            this.comboBoxÜrünListe.TabIndex = 1;
            this.comboBoxÜrünListe.SelectedIndexChanged += new System.EventHandler(this.comboBoxÜrünListe_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxÜrünAçıklama);
            this.groupBox1.Controls.Add(this.textBoxStokAdedi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxYazar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxKategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxÜrünAdı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Ürün Detay Bilgisi";
            // 
            // TextBoxÜrünAçıklama
            // 
            this.TextBoxÜrünAçıklama.Location = new System.Drawing.Point(0, 119);
            this.TextBoxÜrünAçıklama.Name = "TextBoxÜrünAçıklama";
            this.TextBoxÜrünAçıklama.Size = new System.Drawing.Size(440, 89);
            this.TextBoxÜrünAçıklama.TabIndex = 3;
            this.TextBoxÜrünAçıklama.Text = "";
            // 
            // textBoxStokAdedi
            // 
            this.textBoxStokAdedi.Location = new System.Drawing.Point(177, 68);
            this.textBoxStokAdedi.Name = "textBoxStokAdedi";
            this.textBoxStokAdedi.Size = new System.Drawing.Size(263, 20);
            this.textBoxStokAdedi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stok Adedi";
            // 
            // textBoxYazar
            // 
            this.textBoxYazar.Location = new System.Drawing.Point(177, 93);
            this.textBoxYazar.Name = "textBoxYazar";
            this.textBoxYazar.Size = new System.Drawing.Size(263, 20);
            this.textBoxYazar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yazar";
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(177, 42);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(263, 20);
            this.textBoxKategori.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori";
            // 
            // textBoxÜrünAdı
            // 
            this.textBoxÜrünAdı.Location = new System.Drawing.Point(177, 16);
            this.textBoxÜrünAdı.Name = "textBoxÜrünAdı";
            this.textBoxÜrünAdı.Size = new System.Drawing.Size(263, 20);
            this.textBoxÜrünAdı.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxÜrünListe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox İnceleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxÜrünListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox TextBoxÜrünAçıklama;
        private System.Windows.Forms.TextBox textBoxStokAdedi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxÜrünAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

