using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButcePlanlamam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!DesignMode)
            {
                //eğer tasarım anında hata olursa bunu aktifleştirin.
                  //  PaintBackground(e.Graphics);
            }
        }
        [DefaultValue(false)]
        public new bool IsMdiContainer
        {
            get
            {
                return base.IsMdiContainer;
            }
            set
            {
                base.IsMdiContainer = value;
                if (!value) return;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    MdiClient mdiClient = this.Controls[i] as MdiClient;
                    if (mdiClient != null)
                    {
                        mdiClient.Paint += new PaintEventHandler(this.MdiClient_Paint);
                        break;
                    }
                }
            }
        }
        
        private void MdiClient_Paint(object sender, PaintEventArgs e)
        {
            // if (!DesignMode)//eğer tasarım anında hata olursa bunu aktifleştirin.
            //PaintBackground(e.Graphics);
        }

        private void PaintBackground(Graphics g)
        {
            //  this.BackgroundImage = Image.FromFile(@"C:\Users\zeyt\Downloads\ArkaPlan.png");
        }

        private void FormGetir(Form frm)
        {
            panel1.Controls.Clear();
            if (frm.IsMdiChild == true)
            {
                frm.Close();
            }
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ClientSize = new System.Drawing.Size(976, 491);
            panel1.Controls.Add(frm);
            frm.Show();
   
        }
        ClassConnection sınıf = new ClassConnection();
        private void MainForm_Load(object sender, EventArgs e)
        {
            sınıf.OpenConection();
            Anasayfa anasayfa = new Anasayfa();
            FormGetir(anasayfa);
            /*
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackgroundImage = Properties.Resources.Bütçe_Takip_Otomasyonu___Eymen_Karabudak__200130087;
                    // 4#
                    break;
                }
            }
            */
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa frmAnasayfa = new Anasayfa();
            FormGetir(frmAnasayfa);
        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            btnAnasayfa.ForeColor = Color.White;
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            btnAnasayfa.ForeColor = Color.Black;
        }
        ////////////////////////////////
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle duzenle = new Duzenle();
            FormGetir(duzenle);
        }

        private void btnDuzenle_MouseHover(object sender, EventArgs e)
        {
            btnDuzenle.ForeColor = Color.Brown;
        }

        private void btnDuzenle_MouseLeave(object sender, EventArgs e)
        {
            btnDuzenle.ForeColor = Color.Black;
        }
        /////////////////////////////////////////
        private void btnHakkımda_Click(object sender, EventArgs e)
        {
            Hakkımda hakkımda = new Hakkımda();
            FormGetir(hakkımda);
        }

        private void btnHakkımda_MouseHover(object sender, EventArgs e)
        {
            btnHakkımda.ForeColor = Color.Blue;
        }

        private void btnHakkımda_MouseLeave(object sender, EventArgs e)
        {
            btnHakkımda.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Black;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Red;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Black;
        }


    }
}
