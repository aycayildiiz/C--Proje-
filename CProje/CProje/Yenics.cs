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
    public partial class Yenics : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje01;user=root");
        
        public Yenics()
        {
            InitializeComponent();
        }
        private void listele()
        {
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tbl_personeller  ORDER BY sicilno", baglanti);
            DataTable dt = new DataTable();
            baglanti.Open();
            dt.Clear();
            adaptor.Fill(dt); // tabloyu doldur
            adaptor.Dispose(); // adaptörü kapat
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkkapat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Close();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {

            {
                Int32 satir;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                // Insert Into SQL ile tablomuza formdaki verileri
                // parametreli (@) şekilde  gönderiyoruz
                // parametreler SQL injection a karşı tedbir olarak uygulanır
                // Tırnak işaretleri ile uğraşılmak zorunda kalınmaz    
                komut.CommandText = "INSERT INTO tbl_personeller (notlar,ad,soyad,sicilno,unvan,bolum,eposta,odanumarası,isebaslamatarihi)" +
                    "VALUES (@pnotlar,@pad,@psoyad,@psicilno,@punvan,@pbolum,@peposta,@podanumarası,@pisebaslamatarihi)";
                // @ işareti ile başlayan kısım parametreli değişkenlere
                // değerler aktarıyor
                komut.Parameters.AddWithValue("@pnotlar", txtnotlar.Text);
                komut.Parameters.AddWithValue("@pad", txtad.Text);
                komut.Parameters.AddWithValue("@psoyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@psicilno", txtsicilno.Text);
                komut.Parameters.AddWithValue("@punvan", txtunvan.Text);
                komut.Parameters.AddWithValue("@pbolum", txtbolum.Text);
                komut.Parameters.AddWithValue("@peposta", txteposta.Text);
                komut.Parameters.AddWithValue("@podanumarası", txtodanumarası.Text);
                komut.Parameters.AddWithValue("@pisebaslamatarihi", txtisebaslamatarihi.Text);
                komut.Connection = baglanti;
                satir = komut.ExecuteNonQuery();
                MessageBox.Show(satir + " personel eklendi");
                komut.Dispose(); // komut nesnesini yoket
                baglanti.Close(); // bağlantıyı kapat
                listele(); //datagrid tazelensin
            }

        }

        private void txtüstsicil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Int32 satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            // Insert Into SQL ile tablomuza formdaki
            // verileri yine parametreli şekilde dönderiyoruz    
            komut.CommandText = "UPDATE tbl_personeller SET notlar = @pnotlar, ad = @pad ," +
                " soyad = @psoyad, unvan=@punvan,bolum=@pbolum,eposta=@peposta,odanumarası=@podanumarası,isebaslamatarihi=@pisebaslamatarihi " +
                " WHERE  sicilno = @psicilno";
            // @ işareti ile başlayan kısım parametreli değişkenleri
            // ifade ediyor
            komut.Parameters.AddWithValue("@pnotlar", txtnotlar.Text);
            komut.Parameters.AddWithValue("@pad", txtad.Text);
            komut.Parameters.AddWithValue("@psoyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@psicilno", txtsicilno.Text);
            komut.Parameters.AddWithValue("@punvan", txtunvan.Text);
            komut.Parameters.AddWithValue("@pbolum", txtbolum.Text);
            komut.Parameters.AddWithValue("@peposta", txteposta.Text);
            komut.Parameters.AddWithValue("@podanumarası", txtodanumarası.Text);
            komut.Parameters.AddWithValue("@pisebaslamatarihi", txtisebaslamatarihi.Text);
            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satırda personel bilgisi değişti");
            komut.Dispose(); // komut nesnesini yoket
            baglanti.Close(); // bağlantıyı kapat
            listele(); //datagrid tazelensin
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            zimmetliurun zimmetliurun = new zimmetliurun();
            zimmetliurun.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Yenics_Load(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblsicilno_Click(object sender, EventArgs e)
        {

        }

        private void txtustsicilno_TextChanged(object sender, EventArgs e)
        {

            if (txtsicilno.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_personeller WHERE sicilno LIKE '" + txtustsicilno.Text + "'", baglanti);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtad.Text = read["ad"].ToString();
                txtsoyad.Text = read["soyad"].ToString();
                txtsicilno.Text = read["sicilno"].ToString();
                txtunvan.Text = read["unvan"].ToString();
                txtbolum.Text = read["bolum"].ToString();
                txteposta.Text = read["eposta"].ToString();
                txtodanumarası.Text = read["odanumarası"].ToString();
                txtisebaslamatarihi.Text = read["isebaslamatarihi"].ToString();
                txtnotlar.Text = read["notlar"].ToString();


            }
            baglanti.Close();
        }
    }
}
