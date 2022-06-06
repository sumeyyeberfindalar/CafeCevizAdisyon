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
    public partial class frmPersonelEkleme : Form
    {
        public frmPersonelEkleme()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();  
        private void cbGorevId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            //cbGorevId.Items.Clear();
            //SqlConnection con = new SqlConnection(gnl.conString);
            //SqlCommand cmd = new SqlCommand("Select * from personelGorevleri Where GOREV=@gorev", con);


            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    cbGorevId.Items.Add(dr["@gorev"].ToString());

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtParola.Text) && String.IsNullOrEmpty(txtAd.Text) && String.IsNullOrEmpty(txtSoyad.Text) && String.IsNullOrEmpty(txtParolaTekrar.Text) && String.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            if (txtParola.Text == txtParolaTekrar.Text)
            {
                SqlConnection con = new SqlConnection(gnl.conString);
                SqlCommand cmd = new SqlCommand("Insert Into personeller(GOREVID,AD,SOYAD,PAROLA,KULLANICIADI,DURUM)Values(@gorevId,@ad,@soyad,@parola,@kullaniciAdi,@durum)", con);
                try
                {
                   
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.Parameters.Add("@gorevId", System.Data.SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ad", System.Data.SqlDbType.VarChar).Value = txtAd.Text.ToString();
                    cmd.Parameters.Add("@soyad", System.Data.SqlDbType.VarChar).Value = txtSoyad.Text.ToString();
                    cmd.Parameters.Add("@parola", System.Data.SqlDbType.VarChar).Value = txtParola.Text.ToString();
                    cmd.Parameters.Add("@kullaniciAdi", System.Data.SqlDbType.VarChar).Value = txtKullaniciAdi.Text.ToString();
                    cmd.Parameters.Add("@durum", System.Data.SqlDbType.Bit).Value = 0;


                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)

                {
                    string hata = ex.Message;
                    throw;
                }
                    DialogResult secenek = MessageBox.Show("Personel veritabanına eklendi. Giriş ekranına dönmek istiyor musunuz?","BAŞARILI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (secenek == DialogResult.Yes)
                    {
                        frmGiris giris = new frmGiris();   
                        this.Close();
                        giris.Show();
                    }
            }
            else if (txtParolaTekrar.Text != txtParola.Text)
            {
                MessageBox.Show("GİRDİĞİNİZ PAROLALAR EŞLEŞMİYOR.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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

