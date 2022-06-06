using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCeviz
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();  

        cUrunCesitleri Uc = new cUrunCesitleri();   
        private void btnKahveler1_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnKahveler1);
        }

        private void btnCaylar2_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnCaylar2);

        }

        private void btnSogukKahveler3_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnSogukKahveler3);

        }

        private void btnSutluTatlilar4_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnSutluTatlilar4);

        }

        private void btnPastalar5_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnPastalar5);

        }

        private void btnBaklavalar6_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnBaklavalar6);

        }

        private void btnKahvaltılar8_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnKahvaltılar8);

        }
        
        private void btnDondurmalar9_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypesMenu(lvMenu, btnDondurmalar9);

        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKategoriId.Text) && String.IsNullOrEmpty(txtUrunAdi.Text) && String.IsNullOrEmpty(txtAciklama.Text) && String.IsNullOrEmpty(txtFiyat.Text) )
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if (!txtKategoriId.Text.Equals("8") && Convert.ToInt32(txtKategoriId) < 9)
                //{
                    SqlConnection con = new SqlConnection(gnl.conString);
                    SqlCommand cmd = new SqlCommand("Insert Into urunler(KATEGORIID,URUNAD,ACIKLAMA,FIYAT,Durum)Values(@kategoriId,@urunAd,@aciklama,@fiyat,@durum)", con);
                    try
                    {

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.Parameters.Add("@kategoriId", System.Data.SqlDbType.Int).Value = txtKategoriId.Text.ToString();
                        cmd.Parameters.Add("@urunAd", System.Data.SqlDbType.VarChar).Value = txtUrunAdi.Text.ToString();
                        cmd.Parameters.Add("@aciklama", System.Data.SqlDbType.VarChar).Value = txtAciklama.Text.ToString();
                        cmd.Parameters.Add("@fiyat", System.Data.SqlDbType.Decimal).Value = txtFiyat.Text.ToString();
                        cmd.Parameters.Add("@durum", System.Data.SqlDbType.Bit).Value = 0;
                        

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)

                    {
                        string hata = ex.Message;
                        throw;
                    }
                    MessageBox.Show("Ürün veritabanına eklendi.", "BAŞARILI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //}
            //    else
            //{
            //    MessageBox.Show("GİRDİĞİNİZ KATEGORİ ID BULUNMAMAKTADIR. LUTFEN TABLODAN SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
    }
    }

