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
using System.Data.Sql;

namespace ButcePlanlamam
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        ClassConnection sınıf = new ClassConnection();
        static string ConnectionString = @"Data Source=zeyt\sqlexpress;Initial Catalog=Butce;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);

        public void Grafik(SqlCommand cmd)
        {
            foreach (var item in chart1.Series)
            {
                item.Points.Clear();
            }
        }

        public void Listele(string tur)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (tur == "GELİR")
            {
                dataGridView1.DataSource = sınıf.ShowDataInGridView("Select Category_NM,Category_Type,Payment,Note,Tarih from Islem where Category_Type = 'GELİR'");

            }
            else if (tur == "GİDER")
            {

                dataGridView1.DataSource = sınıf.ShowDataInGridView("Select Category_NM,Category_Type,Payment,Note,Tarih from Islem where Category_Type = 'GİDER'");
                //chart1.Titles.Add("HARCAMALARIN DAĞILIMI");
                //SqlCommand cmdkayitSayisi = new SqlCommand("select count(*) from Islem where Category_Type = 'GİDER'",con);
                // SqlCommand cmdkayitSayisi = new SqlCommand("select count(*) Category_NM as 'Kategoriler',AVG(Payment) as 'Ortalamalar' from Islem where Category_Type = 'Gider' group by Category_NM", con);
                //int kayitSayisi = Convert.ToInt32(cmdkayitSayisi.ExecuteScalar());
                //MessageBox.Show(kayitSayisi.ToString());


            }
            else if (tur == "TÜMÜNÜ SIRALA")
            {
                dataGridView1.DataSource = sınıf.ShowDataInGridView("Select Category_NM,Category_Type,Payment,Note,Tarih from Islem");
                SqlDataReader dr = sınıf.DataReader("select Category_NM as 'Kategoriler',AVG(Payment) as 'Ortalamalar' from Islem where Category_Type = 'Gider' group by Category_NM");
                chart1.Series[0].Points.Clear();
                chart1.Series[0].IsValueShownAsLabel = true;
                while (dr.Read())
                {
                    chart1.Series[0].Points.AddXY(dr[0], dr[1]);
                }
                dr.Close();
                SqlCommand cmdbakiye = new SqlCommand("Select ((select COALESCE(sum(Payment),0)  from Islem where Category_Type = 'GELİR')-(select COALESCE(sum(Payment),0)  from Islem where Category_Type = 'GİDER')) as 'BAKİYE'", con);
                decimal bakiye = Convert.ToDecimal(cmdbakiye.ExecuteScalar());
                lblBakiye.Text = bakiye.ToString();

            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            SqlClass.IslemYapildi = false;
            sınıf.OpenConection();
            SqlDataReader reader = sınıf.CboxCek("select distinct Category_Type from Islem", cboxSirala, 0);
            reader.Close();
            cboxSirala.Items.Add("TÜMÜNÜ SIRALA");
            Listele("TÜMÜNÜ SIRALA");
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GelirEkle frmGelir = new GelirEkle();
            frmGelir.Show();
        }

        private void brnGider_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GiderEkle frmGider = new GiderEkle();
            frmGider.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // MessageBox.Show("timer açık işlem yapılmadı");
            if (SqlClass.IslemYapildi == true)
            {
                Listele("TÜMÜNÜ SIRALA");
                SqlClass.IslemYapildi = false;
                timer1.Stop();
                //timer1.Start();
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            Listele(cboxSirala.Text);
        }
    }
}
