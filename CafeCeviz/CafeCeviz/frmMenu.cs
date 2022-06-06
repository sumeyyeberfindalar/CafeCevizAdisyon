using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCeviz
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasaSiparis_Click(object sender, EventArgs e)
        {
            frmMasalar frmMasa = new frmMasalar();    
            this.Close();
            frmMasa.Show();

        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            this.Close();
            frm.Show();  
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();   
            this.Close();
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmPersonelEkleme frm = new frmPersonelEkleme();
            this.Close();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasaIslemleri frm = new frmKasaIslemleri();
            this.Close();
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();    
            this.Close();
            frm.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
           frmAyarlar frm = new frmAyarlar();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnKilitle_Click(object sender, EventArgs e)
        {
            frmLock frm = new frmLock();    
            this.Close();
            frm.Show();
        }
    }
}
