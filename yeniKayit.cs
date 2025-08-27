using ListGenericToDoUygulama.BusinessService;
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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
             ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {
            todoServis todoservis = new todoServis();
            int sonuc = todoservis.yeniKayit(new Entities.todo()
            {
                id = new Guid(),
                baslik = txtBaslik.Text,
                kisaAciklama = txtKisaAciklama.Text,
                aciklama = txtAciklama.Text,
                durumAciklama = cmbBoxDurum.SelectedItem.ToString(),
                onemDerece = int.Parse(txtOnemDerece.Text),
                olusturmaTarih = DateTime.Now
            });
            if (sonuc > 0 )
            {
                MessageBox.Show("Kayıt işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
               DialogResult result =  MessageBox.Show("Yeni kayıt ekleme isşlemine devam etmek ister msiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                        else if (item is ComboBox)
                        {
                            ((ComboBox)item).SelectedIndex = -1;

                        }
                        else if(item is RichTextBox)
                        {
                            ((RichTextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitListe = Application.OpenForms["kayitListe"];
                    if (kayitListe == null)
                    {
                        kayitListe = new kayitListe();
                        kayitListe.MdiParent = Application.OpenForms["Form1"];
                        kayitListe.StartPosition = FormStartPosition.CenterScreen;
                        kayitListe.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox Liste = (GroupBox)kayitListe.Controls["grpBoxListe"];
                        DataGridView grdListe = (DataGridView)Liste.Controls["grdListe"];
                        List<Entities.todo> Guncelliste = todoservis.kayitListe();
                        grdListe.DataSource = null;
                        grdListe.DataSource = todoservis.kayitListe();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yeniKayit_Load(object sender, EventArgs e)
        {
            cmbBoxDurum.Items.Clear();
            cmbBoxDurum.Items.Add("İptal Edildi");
            cmbBoxDurum.Items.Add("Devam Ediyor");
            cmbBoxDurum.Items.Add("Tamamlandı");
        }
    }
}
