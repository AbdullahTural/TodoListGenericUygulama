using ListGenericToDoUygulama.BusinessService;
using ListGenericToDoUygulama.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListGenericToDoUygulama
{
    public partial class sistemGiris : Form
    {
        public sistemGiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                kullaniciServis kullaniciServis = new kullaniciServis();
               kullanici kontrolKullanici =  kullaniciServis.kullaniciKontrol(txtKullaniciAdi.Text , txtSifre.Text);
                if (kontrolKullanici != null)
                {
                    Form anaForm = Application.OpenForms["Form1"];
                    Panel solPanel = (Panel)anaForm.Controls["pnlIslemListesi"];
                    GroupBox grpBoxIslemListe = (GroupBox)solPanel.Controls["grpBoxIslemListe"];
                    foreach (Control item in grpBoxIslemListe.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                   MessageBox.Show("Giriş başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



            }
            else
            {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Bilgilendirme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
