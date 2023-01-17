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
    public partial class Duzenle : Form
    {
        public Duzenle()
        {
            InitializeComponent();
        }
        ClassConnection sınıf = new ClassConnection();
        static string ConnectionString = @"Data Source=zeyt\sqlexpress;Initial Catalog=Butce;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        private void Duzenle_Load(object sender, EventArgs e)
        {
            sınıf.OpenConection();
            listGelir.Items.Clear();
            listGider.Items.Clear();
            SqlDataReader drGelir = sınıf.ListCek("select Category_Name from Category where Category_Type = 'GELİR'", listGelir, 0);
            drGelir.Close();
            SqlDataReader drGider = sınıf.ListCek("select Category_Name from Category where Category_Type = 'GİDER'", listGider, 0);
            drGider.Close();
            dataGridView1.DataSource = sınıf.ShowDataInGridView("Select Islem_Id as 'İşlem Id',Category_NM as 'Kategori İsmi',Category_Type as 'Kategori Tipi',Payment as 'Tutar',Note,Tarih from Islem");
            sınıf.CloseConnection();
        }

        private void btnGelirSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand GelirSil = new SqlCommand("Delete from Category where Category_Name = '" + listGelir.SelectedItem.ToString() + "'", con);
            GelirSil.ExecuteNonQuery();
            MessageBox.Show("Kategori Silindi");
            con.Close();
            Duzenle_Load(sender, e);
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand GelirEkle = new SqlCommand("Insert into Category (Category_Name,Category_Type) values('" + txtGelir.Text + "','GELİR')", con);
            GelirEkle.ExecuteNonQuery();
            MessageBox.Show("Eklendi");
            con.Close();
            Duzenle_Load(sender, e);
        }

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand GiderSil = new SqlCommand("Delete from Category where Category_Name = '" + listGider.SelectedItem.ToString() + "'", con);
            GiderSil.ExecuteNonQuery();
            MessageBox.Show("Kategori Silindi");
            con.Close();
            Duzenle_Load(sender, e);
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand GiderEkle = new SqlCommand("Insert into Category (Category_Name,Category_Type) values('" + txtGider.Text + "','GİDER')", con);
            GiderEkle.ExecuteNonQuery();
            MessageBox.Show("Eklendi");
            con.Close();
            Duzenle_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNot.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTutar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnKayitSi_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand sil = new SqlCommand("Delete from Islem where Islem_Id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silindi");
            con.Close();
            Duzenle_Load(sender, e);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand guncelle = new SqlCommand("Update Islem set Payment = '" + txtTutar.Text + "',Note = '" + txtNot.Text + "' where Islem_Id =" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ", con);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
            con.Close();
            Duzenle_Load(sender, e);
        }
    }
}
