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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.oledb.12.0;Data Source = diyet.accdb");

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = kayitol;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        float kilo;
        float kalori;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //Hesapla buton
            kilo = float.Parse(kilotext.Text);
            if(radiokadin.Checked == true)
            {
                if(radioButton3.Checked == true)
                {
                    kalori = (kilo * 19)+150;
                }
                else if(radioButton4.Checked == true)
                {
                    kalori = (kilo * 20) + 200;
                }
                else if(radioButton5.Checked == true)
                {
                    kalori = (kilo * 21) + 250;
                }
            }
            else
            {
                if (radioButton3.Checked == true)
                {
                    kalori = (kilo * 20) + 200;
                }
                else if (radioButton4.Checked == true)
                {
                    kalori = (kilo * 21) + 250;
                }
                else if (radioButton5.Checked == true)
                {
                    kalori = (kilo * 22) + 300;
                }
            }
            label10.Text = kalori.ToString()+" kcal";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //SQL KOMUTLARI  çalışıp ana ekrana geçiçek 
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("insert into bilgiler values (@isim,@cinsiyet,@yas,@kilo,@aktivite,@kcal)",baglanti);
            ekle.Connection = baglanti;
            ekle.Parameters.Add("@isim",isim.Text);
            if(radiokadin.Checked == true)
            {
                ekle.Parameters.Add("@cinsiyet", radiokadin.Text);
            }
            else
            {
                ekle.Parameters.Add("@cinsiyet", radioerkek.Text);
            }
            ekle.Parameters.Add("@yas",yas.Text);
            ekle.Parameters.Add("@kilo",float.Parse(kilotext.Text));

            if(radioButton3.Checked == true)
            {
                ekle.Parameters.Add("@aktivite", radioButton3.Text);
            }else if(radioButton4.Checked == true)
            {
                ekle.Parameters.Add("@aktivite", radioButton4.Text);
            }else if(radioButton5.Checked == true)
            {
                ekle.Parameters.Add("@aktivite", radioButton5.Text);
            }
            ekle.Parameters.Add("@kcal",kalori);
            if(ekle.ExecuteNonQuery()> 0)
            {
                MessageBox.Show("Kayıt işlemi başarılı.");
                tabControl1.SelectedTab = girisyap;
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız.");
            }
            baglanti.Close();
        }
        public static String kisim;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Sql den isime göre çekme yap ondan sonra form 3 e pasla
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select * from bilgiler where isim = @isim",baglanti);
            giris.Parameters.Add("@isim", isimtext.Text);
            giris.Connection = baglanti;
            OleDbDataReader oku;
            oku = giris.ExecuteReader();
            if (oku.HasRows == true)
            {
                kisim = isimtext.Text;
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu isimde bir kayıt yoktur lütfen kayıt olunuz!");
            }
            baglanti.Close();

        }
    }
}
