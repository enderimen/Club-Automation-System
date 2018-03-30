using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MetroUI
{
  public partial class Kulüp_Yönetimi : MetroForm
  {
    public Kulüp_Yönetimi()
    {
      InitializeComponent();
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");
    private void btnGuncelle_Click_1(object sender, EventArgs e)
    {
      connection.Open();
      SqlCommand guncelle = new SqlCommand("update Uyeler set uye_ad='" + textBox2.Text + "',uye_soyad='" + textBox3.Text + "',uye_sinif='" + textBox4.Text + "',uye_gorev='" + textBox5.Text + "' where uye_id='" + textBox1.Text + "'", connection);
      guncelle.ExecuteNonQuery();
      connection.Close();

      MessageBox.Show("Kayıt Değiştirildi");
      anasayfa k = Application.OpenForms["anasayfa"] as anasayfa;
      k.kadroListele();
      this.Close();
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      textBox2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text);
    }

    private void textBox3_Leave(object sender, EventArgs e)
    {
      textBox3.Text=textBox3.Text.ToUpper();
    }

    private void textBox5_Leave(object sender, EventArgs e)
    {
      textBox5.Text = textBox5.Text.ToUpper();
    }
  }
}
