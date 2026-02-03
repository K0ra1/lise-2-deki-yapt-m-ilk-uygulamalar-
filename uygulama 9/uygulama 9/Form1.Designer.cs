namespace uygulama_9
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
            this.txtSatirSayisi = new System.Windows.Forms.TextBox();
            this.txtSutunSayisi = new System.Windows.Forms.TextBox();
            this.txtRastgeleMin = new System.Windows.Forms.TextBox();
            this.txtRastgeleMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiziOluştur = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.listeDizi = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSatirSayisi
            // 
            this.txtSatirSayisi.Location = new System.Drawing.Point(225, 54);
            this.txtSatirSayisi.Name = "txtSatirSayisi";
            this.txtSatirSayisi.Size = new System.Drawing.Size(59, 20);
            this.txtSatirSayisi.TabIndex = 0;
            // 
            // txtSutunSayisi
            // 
            this.txtSutunSayisi.Location = new System.Drawing.Point(225, 111);
            this.txtSutunSayisi.Name = "txtSutunSayisi";
            this.txtSutunSayisi.Size = new System.Drawing.Size(59, 20);
            this.txtSutunSayisi.TabIndex = 1;
            // 
            // txtRastgeleMin
            // 
            this.txtRastgeleMin.Location = new System.Drawing.Point(225, 160);
            this.txtRastgeleMin.Name = "txtRastgeleMin";
            this.txtRastgeleMin.Size = new System.Drawing.Size(59, 20);
            this.txtRastgeleMin.TabIndex = 2;
            // 
            // txtRastgeleMax
            // 
            this.txtRastgeleMax.Location = new System.Drawing.Point(225, 214);
            this.txtRastgeleMax.Name = "txtRastgeleMax";
            this.txtRastgeleMax.Size = new System.Drawing.Size(59, 20);
            this.txtRastgeleMax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dizi Sütun Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dizi Satır Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rastgele En Düşük ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rastgele En Yüksek";
            // 
            // btnDiziOluştur
            // 
            this.btnDiziOluştur.Location = new System.Drawing.Point(209, 282);
            this.btnDiziOluştur.Name = "btnDiziOluştur";
            this.btnDiziOluştur.Size = new System.Drawing.Size(75, 23);
            this.btnDiziOluştur.TabIndex = 7;
            this.btnDiziOluştur.Text = "Dizi Oluştur";
            this.btnDiziOluştur.UseVisualStyleBackColor = true;
            this.btnDiziOluştur.Click += new System.EventHandler(this.btnDiziOluştur_Click);
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(459, 70);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 23);
            this.btnListe.TabIndex = 8;
            this.btnListe.Text = "Dizi Göster";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // listeDizi
            // 
            this.listeDizi.FormattingEnabled = true;
            this.listeDizi.Location = new System.Drawing.Point(440, 111);
            this.listeDizi.Name = "listeDizi";
            this.listeDizi.Size = new System.Drawing.Size(120, 134);
            this.listeDizi.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sıfırıla ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listeDizi);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btnDiziOluştur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRastgeleMax);
            this.Controls.Add(this.txtRastgeleMin);
            this.Controls.Add(this.txtSutunSayisi);
            this.Controls.Add(this.txtSatirSayisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatirSayisi;
        private System.Windows.Forms.TextBox txtSutunSayisi;
        private System.Windows.Forms.TextBox txtRastgeleMin;
        private System.Windows.Forms.TextBox txtRastgeleMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiziOluştur;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.ListBox listeDizi;
        private System.Windows.Forms.Button button1;
    }
}

