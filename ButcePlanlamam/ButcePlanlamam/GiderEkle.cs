using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ButcePlanlamam
{
    public partial class GiderEkle : Form
    {
        public GiderEkle()
        {
            InitializeComponent();
        }
        ClassConnection sınıf = new ClassConnection();
        static string strEkle = @"insert into Islem (Category_NM,Category_Type,Payment,Note,Tarih) values(@kt_isim,@kt_tip,@odeme,@not,@tarih)";
        private void GiderEkle_Load(object sender, EventArgs e)
        {
            sınıf.OpenConection();
            SqlDataReader dr = sınıf.CboxCek("Select *from Category where Category_Type = 'GİDER'", cbox_Kategori, 1);
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

            if (cbox_Kategori.Text == String.Empty || txtTutar.Text == String.Empty)
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
                    ekle.Parameters.AddWithValue("@kt_isim", cbox_Kategori.Text);
                    ekle.Parameters.AddWithValue("@kt_tip", "GİDER");
                    ekle.Parameters.AddWithValue("@odeme", txtTutar.Text);
                    ekle.Parameters.AddWithValue("@not", txtNot.Text);
                    ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
                    a = ekle.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Başarıyla Eklendi");
                        txtTutar.Text = String.Empty;
                        cbox_Kategori.Text = String.Empty;
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
