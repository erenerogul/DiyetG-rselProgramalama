using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DiyetGörselProgramalama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.oledb.12.0;Data Source = diyet.accdb");
        decimal alinan_kalori = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            hgisimLabel.Text = Form2.kisim;
            baglanti.Open();
            OleDbCommand getir = new OleDbCommand();
            getir.CommandText = "Select * from bilgiler where isim=@isim";
            getir.Connection = baglanti;
            getir.Parameters.Add("@isim", Form2.kisim);
            OleDbDataReader oku;
            oku = getir.ExecuteReader();
            oku.Read();// Bunu veri getirtmek için mecbursun 
            String cinsiyet = oku[1].ToString();
            int kcal =int.Parse(oku[5].ToString());
            gerekenkaloriLabel.Text = kcal.ToString();
            if(cinsiyet == "Kadın")
            {
                ppBox.ImageLocation = @"profile/female_in_love_125px.png";
            }else if(cinsiyet =="Erkek")
            {
                ppBox.ImageLocation = @"profile/lol_male_125px.png";
            }
            baglanti.Close();
        }

        private void button_kahvalti_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = kahvalti;
        }

        private void button_ogleyemegi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ogleyemegi;
        }

        private void button_aksamyemegi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = aksamyemegi;
        }

        private void button_araogun_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = araogun;
        }

        private void button_icecekler_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = icecekler;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void yumurtaNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (yumurtaNumeric.Value*155);
            alinankaloriLabel.Text = alinan_kalori.ToString() +" kcal";
        }

        private void recelNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (recelNumeric.Value * 278);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void balNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (balNumeric.Value * 304);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void krepNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (krepNumeric.Value * 153);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void ekmekNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (ekmekNumeric.Value * 264);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void peynirNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (peynirNumeric.Value * 402);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void cookieNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (cookieNumeric.Value * 65);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void buritoNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (buritoNumeric.Value * 400);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void hamburgerNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (hamburgerNumeric.Value * 300);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void makarnaNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (makarnaNumeric.Value * 131);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void patatesNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (patatesNumeric.Value * 164);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void tavukNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (tavukNumeric.Value * 239);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void pizzaNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (pizzaNumeric.Value * 266);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void pilavNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (pilavNumeric.Value * 359);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void salataNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (salataNumeric.Value * 31);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void kapkekNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (kapkekNumeric.Value * 305);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void cikolataNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (cikolataNumeric.Value * 200);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void karpuzNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (karpuzNumeric.Value * 30);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void kayisiNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (kayisiNumeric.Value * 59);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";
        }

        private void avokadoNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (avokadoNumeric.Value * 160);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }

        private void fistukNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (fistukNumeric.Value * 567);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }

        private void kahveNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (kahveNumeric.Value * 2);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }

        private void kolaNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (kolaNumeric.Value * 37);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }

        private void sutNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (sutNumeric.Value * 42);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }

        private void smutiNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (smutiNumeric.Value * 111);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }

        private void cayNumeric_ValueChanged(object sender, EventArgs e)
        {
            alinan_kalori += (cayNumeric.Value * 1);
            alinankaloriLabel.Text = alinan_kalori.ToString() + " kcal";

        }
    }
}
