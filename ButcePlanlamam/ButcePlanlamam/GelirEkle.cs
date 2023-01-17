using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ButcePlanlamam
{
    public partial class GelirEkle : Form
    {
        public GelirEkle()
        {
            InitializeComponent();
        }
        ClassConnection sınıf = new ClassConnection();
        SqlClass sınıf2 = new SqlClass();
        static string strEkle = @"insert into Islem (Category_NM,Category_Type,Payment,Note,Tarih) values(@kt_isim,@kt_tip,@odeme,@not,@tarih)";
        public static bool IslemYapildi;
        private void GelirEkle_Load(object sender, EventArgs e)
        {
            sınıf.OpenConection();
            SqlDataReader dre = sınıf.CboxCek("Select *from Category where Category_Type = 'GELİR'", cboxKategori, 1);
            IslemYapildi = false;
        }
        public void KontrolEt(ComboBox cb, TextBox tutar)
        {
            if (cb.Text == String.Empty || tutar.Text == String.Empty)
            {
                MessageBox.Show("Kategori ve Tutar alanını boş bırakmayınız !!");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int a;
            string ConnectionString = @"Data Source=zeyt\sqlexpress;Initial Catalog=Butce;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand ekle = new SqlCommand(strEkle, con);

            if (cboxKategori.Text == String.Empty || txtTutar.Text == String.Empty)
            {
                MessageBox.Show("Kategori ve Tutar alanını boş bırakmayınız !!");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    ekle.Parameters.AddWithValue("@kt_isim", cboxKategori.Text);
                    ekle.Parameters.AddWithValue("@kt_tip", "GELİR");
                    ekle.Parameters.AddWithValue("@odeme", txtTutar.Text);
                    ekle.Parameters.AddWithValue("@not", txtNot.Text);
                    ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
                    a = ekle.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Başarıyla Eklendi");
                        txtTutar.Text = String.Empty;
                        cboxKategori.Text = String.Empty;
                        txtNot.Text = String.Empty;
                        SqlClass.IslemYapildi = true;
                    }
                    sınıf.CloseConnection();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }

        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

