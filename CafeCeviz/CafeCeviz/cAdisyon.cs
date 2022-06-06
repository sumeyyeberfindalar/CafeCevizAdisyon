
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeCeviz
{
    internal class cAdisyon
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;

        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }

        #endregion    }

        public int GetByAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From adisyonlar Where MASAID=@MasaId Order by ID desc", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@MasaID", System.Data.SqlDbType.Int).Value = MasaId; ;


            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
              MasaId =Convert.ToInt32(cmd.ExecuteScalar()); 
            }

            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
        
                con.Close();
            }
            return MasaId;
        }

        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into adisyonlar(SERVİSTURNO,PERSONELID,MASAID,TARIH,Durum) values (@ServisTurNo,@PersonelID,@MasaId,@Tarih,@Durum)", con);
            try
            {


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", System.Data.SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@PersonelID", System.Data.SqlDbType.Int).Value = Bilgiler.PersonelId;

                cmd.Parameters.Add("@MasaId", System.Data.SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Tarih", System.Data.SqlDbType.DateTime).Value = Bilgiler.Tarih;

                cmd.Parameters.Add("@Durum", System.Data.SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }finally
            {
                con.Dispose();
                con.Close();    
            }
            return sonuc;

        }
        
    }
}