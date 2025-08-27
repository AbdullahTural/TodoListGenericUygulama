using ListGenericToDoUygulama.BusinessService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListGenericToDoUygulama
{
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButonAcKapa(bool kontrol)
        {
            foreach (Control item in grpBoxIslemListe.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = kontrol;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tm_zamanla.Interval = 15000;
            tm_zamanla.Tick += Tm_zamanla_Tick;
            tm_zamanla.Start();
        
           ButonAcKapa(false);

            sistemGiris KullaniciKontrol = new sistemGiris();
            KullaniciKontrol.MdiParent = this;
            KullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;
            KullaniciKontrol.Show();

        }

        private void Tm_zamanla_Tick(object sender, EventArgs e)
        {
            lbl_zaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }

        private void btnUygulamaKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["yeniKayit"] != null)
            {
                T = Application.OpenForms["yeniKayit"];
                T.Focus();
            }
            else
            {
                T = new yeniKayit();
                T.MdiParent = this; // Form1 formu yeniKayit Formunun sahibidir.  (Multiple Document Interface - MDI)
                T.Show();
            }
        }

        private void btnKayitListe_Click(object sender, EventArgs e)
        {
            todoServis todoServis = new todoServis();
            if (todoServis.todoKontrol() > 0)
            {
                kayitListe kayitListe = new kayitListe();
                kayitListe.MdiParent = this; // Form1 formu kayitListe Formunun sahibidir.
                kayitListe.Show();
            }
            else
            {
                MessageBox.Show("Kayıtlı veri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
