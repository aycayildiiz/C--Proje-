using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CProje
{
    public partial class Form1 : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje01;user=root");

        public Form1()
        {
            InitializeComponent();
        }

        private void lblsifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        KullaniciFormu yonetici = new KullaniciFormu();

      
        private void bttngiris_Click(object sender, EventArgs e)
        {
           
            yonetici.yonetici(txtkullaniciadi, txtsifre);

          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
       

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        KullaniciFormu k = new KullaniciFormu();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

            k.kullanici(txtkullaniciadi, txtsifre);
            calisangirisi calisangirisi = new calisangirisi();
            calisangirisi.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
