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
    public partial class kayitListe : Form
    {
        todoServis todoServis;
        public kayitListe()
        {
            InitializeComponent();
            todoServis = new todoServis();
        }

        private void kayitListe_Load(object sender, EventArgs e)
        {
            grdListe.DataSource = listeGetir();
            grdListe.Columns["id"].Visible = false;
        }

        private List<todo> listeGetir()
        {
            return todoServis.kayitListe();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = listeGetir();
            grdListe.Columns["id"].Visible = false;
        }

        private void btnTamamlandı_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = listeGetir()
                .Where(x => x.durumAciklama == "Tamamlandı")
                .ToList(); 
            grdListe.Columns["id"].Visible = false;
        }

        private void btnTamamlanmadı_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = listeGetir().Where(x => x.durumAciklama != "Tamamlandı").ToList();
            grdListe.Columns["id"].Visible = false;
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = listeGetir()
                .Where(x => x.durumAciklama == "İptal Edildi")
                .ToList();
            grdListe.Columns["id"].Visible = false;
        }
    }
}
