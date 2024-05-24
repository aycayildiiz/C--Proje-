using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CProje
{
    public partial class zimmetliurun : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje01;user=root");
       
        
        MySqlDataAdapter adapter;
        DataTable dt;
        public zimmetliurun()
        {
            InitializeComponent();
        }
       
        private void zimmetliurun_Load(object sender, EventArgs e)
        {

            listele();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasabilgilerics kasa= new kasabilgilerics();    
            kasa.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listele()
        {
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT sicilno,marka, model, aciklama, verildigitarih FROM tbl_personeller", baglanti);
            DataTable dte = new DataTable();

            dte.Clear();
            adaptor.Fill(dte); // tabloyu doldur
            dataGridView1.DataSource = dte; //dt datagrid doldur
            adaptor.Dispose(); // adaptörü kapat
            baglanti.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtverildiğitarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 satir;
            DialogResult cevap;
            cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                // Yine parametreli şekilde göderiyoruz
                komut.CommandText = "DELETE FROM tbl_personeller WHERE marka";
                // @ işareti ile başlayan kısım parametreli değişkenleri ifade ediyor
                
                komut.Connection = baglanti;
                satir = komut.ExecuteNonQuery();
                MessageBox.Show( " Personele ait zimmetli ürün bilgisi silindi");
                komut.Dispose();
                baglanti.Close();
                listele();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
