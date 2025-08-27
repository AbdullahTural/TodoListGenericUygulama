namespace ListGenericToDoUygulama
{
    partial class kayitListe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxListe = new System.Windows.Forms.GroupBox();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.btnListe = new System.Windows.Forms.Button();
            this.btnTamamlandı = new System.Windows.Forms.Button();
            this.btnTamamlanmadı = new System.Windows.Forms.Button();
            this.btnIptalEdildi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptalEdildi);
            this.groupBox1.Controls.Add(this.btnTamamlanmadı);
            this.groupBox1.Controls.Add(this.btnTamamlandı);
            this.groupBox1.Controls.Add(this.btnListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // grpBoxListe
            // 
            this.grpBoxListe.Controls.Add(this.grdListe);
            this.grpBoxListe.Location = new System.Drawing.Point(213, 22);
            this.grpBoxListe.Name = "grpBoxListe";
            this.grpBoxListe.Size = new System.Drawing.Size(897, 410);
            this.grpBoxListe.TabIndex = 1;
            this.grpBoxListe.TabStop = false;
            this.grpBoxListe.Text = "Liste";
            // 
            // grdListe
            // 
            this.grdListe.AllowUserToAddRows = false;
            this.grdListe.AllowUserToDeleteRows = false;
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(3, 18);
            this.grdListe.Name = "grdListe";
            this.grdListe.ReadOnly = true;
            this.grdListe.RowHeadersWidth = 51;
            this.grdListe.RowTemplate.Height = 24;
            this.grdListe.Size = new System.Drawing.Size(891, 389);
            this.grdListe.TabIndex = 0;
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(18, 60);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(170, 39);
            this.btnListe.TabIndex = 1;
            this.btnListe.Text = "Tüm Liste";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnTamamlandı
            // 
            this.btnTamamlandı.Location = new System.Drawing.Point(18, 105);
            this.btnTamamlandı.Name = "btnTamamlandı";
            this.btnTamamlandı.Size = new System.Drawing.Size(170, 39);
            this.btnTamamlandı.TabIndex = 1;
            this.btnTamamlandı.Text = "Tamamlandı";
            this.btnTamamlandı.UseVisualStyleBackColor = true;
            this.btnTamamlandı.Click += new System.EventHandler(this.btnTamamlandı_Click);
            // 
            // btnTamamlanmadı
            // 
            this.btnTamamlanmadı.Location = new System.Drawing.Point(18, 150);
            this.btnTamamlanmadı.Name = "btnTamamlanmadı";
            this.btnTamamlanmadı.Size = new System.Drawing.Size(170, 39);
            this.btnTamamlanmadı.TabIndex = 1;
            this.btnTamamlanmadı.Text = "Tamamlanmadı";
            this.btnTamamlanmadı.UseVisualStyleBackColor = true;
            this.btnTamamlanmadı.Click += new System.EventHandler(this.btnTamamlanmadı_Click);
            // 
            // btnIptalEdildi
            // 
            this.btnIptalEdildi.Location = new System.Drawing.Point(18, 195);
            this.btnIptalEdildi.Name = "btnIptalEdildi";
            this.btnIptalEdildi.Size = new System.Drawing.Size(170, 39);
            this.btnIptalEdildi.TabIndex = 1;
            this.btnIptalEdildi.Text = "İptal Edildi";
            this.btnIptalEdildi.UseVisualStyleBackColor = true;
            this.btnIptalEdildi.Click += new System.EventHandler(this.btnIptalEdildi_Click);
            // 
            // kayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 444);
            this.Controls.Add(this.grpBoxListe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "to do - Kayıt Liste";
            this.Load += new System.EventHandler(this.kayitListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxListe;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Button btnIptalEdildi;
        private System.Windows.Forms.Button btnTamamlanmadı;
        private System.Windows.Forms.Button btnTamamlandı;
        private System.Windows.Forms.Button btnListe;
    }
}