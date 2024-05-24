using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CProje
{
    internal class KullaniciFormu
    {
        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje01;user=root");
        MySqlDataReader read;
        MySqlCommand komut;
        Yenics yeni=new Yenics();
        //calisanyeni calisanyeni = new calisanyeni();

        public MySqlDataReader kullanici(TextBox eposta, TextBox sifre)
        {
            baglanti.Open();
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_personeller WHERE eposta='" + eposta.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    //calisanyeni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata1");
                }
            }

            baglanti.Close();
            return read;
        }

        public MySqlDataReader yonetici(TextBox eposta, TextBox sifre)
        {
            baglanti.Open();
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_kullanici WHERE eposta='" + eposta.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    yeni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata1");
                }
            }
          
            baglanti.Close();
            return read;
        }


    }
    }

