using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ayçiçeği_Pansiyon_Uygulaması_v1._0
{
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UA65UTX;Initial Catalog=AycicegiPansiyon;Integrated Security=True");


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(tbPersonelSayisi.Text);
            lblPersonelMaas.Text = (personel * 1500).ToString();

            int sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblPersonelMaas.Text) + Convert.ToInt32(lblAlınanUrunGida.Text) + Convert.ToInt32(lblAlınanUrunIcecek.Text) + Convert.ToInt32(lblAlınanUrunCerez.Text) + Convert.ToInt32(lblFaturaElektrik.Text) + Convert.ToInt32(lblFaturaSu.Text) + Convert.ToInt32(lblFaturaDogalgaz.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Tutar
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select sum (Ucret) as toplam1 from MusteriEkle", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                lblKasaToplam.Text = oku1["toplam1"].ToString();
            }
            baglanti.Close();

            //Gıda Giderleri
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select sum (Gida) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlınanUrunGida.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();

            //İçecek Giderleri
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("select sum (Icecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlınanUrunIcecek.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();

            //Çerez Giderleri
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select sum (Cerezler) as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlınanUrunCerez.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select sum (Elektrik) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturaElektrik.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select sum (Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturaSu.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

            //Doğalgaz
            baglanti.Open();

            SqlCommand komut7 = new SqlCommand("select sum (Dogalgaz) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturaDogalgaz.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();
        }
    }
}
