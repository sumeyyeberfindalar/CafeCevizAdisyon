using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CafeCeviz
{
    internal class cPersoneller
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullanıcıAdı;
        private bool _PersonelDurum;
        #endregion

        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGorevId { get => _PersonelGorevId; set => _PersonelGorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullanıcıAdı { get => _PersonelKullanıcıAdı; set => _PersonelKullanıcıAdı = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }

        #endregion 

        public bool personelEntryControl(String password,int UserId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personeller where ID=@Id and PAROLA =@password", con);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open(); 
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
              
            }

            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
        public void PersonelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personeller", con);
           
            
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
               SqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                    cPersoneller p = new cPersoneller();
                    p._PersonelId = Convert.ToInt32(dr["ID"]);
                    p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                    p._PersonelAd = Convert.ToString(dr["AD"]);
                    p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                    p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                    p._PersonelKullanıcıAdı = Convert.ToString(dr["KULLANICIADI"]);
                    p._PersonelDurum = Convert.ToBoolean(dr["DURUM"]);
                    cb.Items.Add(p);



            }
                 dr.Close();
                 con.Close();

        }
        public override string ToString()
        {
            return _PersonelAd +" "+ _PersonelSoyad;
        }
        public bool AddPersonel(cPersoneller pr)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into personeller(GOREVID,AD,SOYAD,PAROLA,KULLANICIADI,DURUM)Values(@gorevId,@ad,@soyad,@parola,@kullaniciAdi,@durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@gorevId", System.Data.SqlDbType.Int).Value = pr._PersonelGorevId;
                cmd.Parameters.Add("@ad", System.Data.SqlDbType.VarChar).Value = pr._PersonelAd;
                cmd.Parameters.Add("@soyad", System.Data.SqlDbType.VarChar).Value = pr._PersonelSoyad;
                cmd.Parameters.Add("@parola", System.Data.SqlDbType.VarChar).Value = pr._PersonelParola;
                cmd.Parameters.Add("@kullaniciAdi", System.Data.SqlDbType.VarChar).Value = pr._PersonelKullanıcıAdı;
                cmd.Parameters.Add("@durum", System.Data.SqlDbType.Bit).Value = 0;


                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)

            {
                string hata = ex.Message;
                throw;
            }


            return result;
        }
        public void PersonelGetByGorevId(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personelGorevleri", con);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                p._PersonelKullanıcıAdı = Convert.ToString(dr["KULLANICIADI"]);
                p._PersonelDurum = Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(p);



            }
            dr.Close();
            con.Close();

        }
    }
    }
