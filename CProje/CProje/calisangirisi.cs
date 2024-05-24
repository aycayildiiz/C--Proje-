using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProje
{
    public partial class calisangirisi : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje01;user=root");
       

        public calisangirisi()
        {
            InitializeComponent();
        }

        KullaniciFormu k = new KullaniciFormu();

        private void bttngiris_Click(object sender, EventArgs e)
        {
            k.kullanici(txtkullaniciadi, txtsifre);
            //calisanyeni calisanyeni = new calisanyeni();
            //calisanyeni.ShowDialog();

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.ShowDialog();
        }
    }
}
