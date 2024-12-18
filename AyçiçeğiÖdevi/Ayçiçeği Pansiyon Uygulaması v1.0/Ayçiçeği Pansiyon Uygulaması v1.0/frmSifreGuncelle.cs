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
    public partial class frmSifreGuncelle : Form
    {
        public frmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UA65UTX;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "', Sifre='"+TxtSifre.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarıyla tamamlandı. Uygulamadan çıkış yapıp tekrar giriniz!");
            baglanti.Close();
        }
    }
}
