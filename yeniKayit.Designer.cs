namespace ListGenericToDoUygulama
{
    partial class yeniKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKayitEt = new System.Windows.Forms.Button();
            this.cmbBoxDurum = new System.Windows.Forms.ComboBox();
            this.txtOnemDerece = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtKisaAciklama = new System.Windows.Forms.RichTextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kısa Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Önem Derecesi";
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.Location = new System.Drawing.Point(187, 244);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(193, 23);
            this.btnKayitEt.TabIndex = 4;
            this.btnKayitEt.Text = "Kayıt Et";
            this.btnKayitEt.UseVisualStyleBackColor = true;
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // cmbBoxDurum
            // 
            this.cmbBoxDurum.FormattingEnabled = true;
            this.cmbBoxDurum.Location = new System.Drawing.Point(187, 212);
            this.cmbBoxDurum.Name = "cmbBoxDurum";
            this.cmbBoxDurum.Size = new System.Drawing.Size(193, 24);
            this.cmbBoxDurum.TabIndex = 5;
            // 
            // txtOnemDerece
            // 
            this.txtOnemDerece.Location = new System.Drawing.Point(187, 180);
            this.txtOnemDerece.Name = "txtOnemDerece";
            this.txtOnemDerece.Size = new System.Drawing.Size(193, 22);
            this.txtOnemDerece.TabIndex = 1;
            this.txtOnemDerece.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtOnemDerece.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(187, 25);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(193, 22);
            this.txtBaslik.TabIndex = 6;
            // 
            // txtKisaAciklama
            // 
            this.txtKisaAciklama.Location = new System.Drawing.Point(187, 48);
            this.txtKisaAciklama.Name = "txtKisaAciklama";
            this.txtKisaAciklama.Size = new System.Drawing.Size(193, 51);
            this.txtKisaAciklama.TabIndex = 7;
            this.txtKisaAciklama.Text = "";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(187, 106);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(193, 68);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.Text = "";
            // 
            // yeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 320);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKisaAciklama);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.cmbBoxDurum);
            this.Controls.Add(this.btnKayitEt);
            this.Controls.Add(this.txtOnemDerece);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "yeniKayit";
            this.Text = "TO DO - Yeni Kayıt";
            this.Load += new System.EventHandler(this.yeniKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKayitEt;
        private System.Windows.Forms.ComboBox cmbBoxDurum;
        private System.Windows.Forms.TextBox txtOnemDerece;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.RichTextBox txtKisaAciklama;
        private System.Windows.Forms.RichTextBox txtAciklama;
    }
}