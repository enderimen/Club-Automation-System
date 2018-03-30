using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.IO;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace MetroUI
{
  public partial class yeniKayitForm : MetroForm
  {
      private int _ID,islem;
    public yeniKayitForm(int pr1,int islem)
    {  
        if (pr1 == 0 && islem == 0)
          {
            System.Windows.Forms.MessageBox.Show("Lütfen kayıt seçiniz. " + pr1);
              //this.Close();
          }     
              this.islem=islem;
              InitializeComponent();
              this._ID = pr1;
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");
  
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || label8.Text == "")
      {
        System.Windows.Forms.MessageBox.Show("LÜTFEN YILDIZLI ALANLARI DOLDURUNUZ");
      }
      else
      {
        connection.Open();

        SqlCommand cekle = new SqlCommand("insert into Uyeler (uye_ad,uye_soyad,uye_sinif,uye_no,uye_adres,uye_telefon,uye_kayitucreti,uye_gorev,uye_kayityil,uye_resim) values (@prmtr2,@prmtr3,@prmtr4,@prmtr5,@prmtr6,@prmtr7,@prmtr8,@prmtr9,@prmtr10,@prmtr11)", connection);

        cekle.Parameters.AddWithValue("@prmtr2", textBox1.Text);
        cekle.Parameters.AddWithValue("@prmtr3", textBox2.Text);
        cekle.Parameters.AddWithValue("@prmtr4", comboBox1.Text);
        cekle.Parameters.AddWithValue("@prmtr5", textBox4.Text);
        cekle.Parameters.AddWithValue("@prmtr6", textBox5.Text);
        cekle.Parameters.AddWithValue("@prmtr7", maskedTextBox1.Text);
        cekle.Parameters.AddWithValue("@prmtr8", textBox6.Text);
        cekle.Parameters.AddWithValue("@prmtr9", textBox7.Text);
        cekle.Parameters.AddWithValue("@prmtr10", dateTimePicker1.Text);
        cekle.Parameters.AddWithValue("@prmtr11", label8.Text);
        cekle.ExecuteNonQuery();

        connection.Close();
        MessageBox.Show("KAYIT BAŞARILI");
        this.Close();
        anasayfa a = Application.OpenForms["anasayfa"] as anasayfa;
        a.uyelerListele();
      }
    }

    private void btnGozat_Click(object sender, EventArgs e)
    {
      OpenFileDialog dosya = new OpenFileDialog();
      dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
      dosya.ShowDialog();
      string dosyayolu = dosya.FileName;
      label8.Text = dosyayolu;
      pictureBox1.ImageLocation = dosyayolu;
    }

      private void yeniKayitForm_Load(object sender, EventArgs e)
      {
          label8.Text="C:\\DATA\\proje\\proje\\MetroUI\\MetroUI\\MetroUI\\bin\\Debug\\img\\userlogo.png";
          if(islem==0)
          {
               btnKaydet.Visible = false;
               this.Text="Güncelle";
                connection.Open();

                SqlCommand bul = new SqlCommand("select * FROM Uyeler WHERE uye_id=@prmtr1", connection);
                bul.Parameters.AddWithValue("@prmtr1", _ID);


                SqlDataReader drEd = bul.ExecuteReader();
                if (drEd.Read())
                {
                    textBox1.Text = drEd["uye_ad"].ToString();
                    textBox2.Text = drEd["uye_soyad"].ToString();
                    comboBox1.Text = drEd["uye_sinif"].ToString();
                    textBox4.Text = drEd["uye_no"].ToString();
                    textBox5.Text = drEd["uye_adres"].ToString();
                    maskedTextBox1.Text = drEd["uye_telefon"].ToString();
                    textBox6.Text = drEd["uye_kayitucreti"].ToString();
                    textBox7.Text = drEd["uye_gorev"].ToString();
                    dateTimePicker1.Text = drEd["uye_kayityil"].ToString();
                    pictureBox1.ImageLocation=drEd["uye_resim"].ToString();
                }
                connection.Close();
          }
          else
          {
              btnGuncelle.Visible = false;
          }
      
  
    }

      private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
      {
          char ch = e.KeyChar;
          if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
          {
              e.Handled = true;
          }
      }

      private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
      {
          char ch = e.KeyChar;
          if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
          {
              e.Handled = true;
          }
      }

      private void btnGuncelle_Click_1(object sender, EventArgs e)
      {
        connection.Open();
        SqlCommand guncelle = new SqlCommand("update Uyeler set uye_ad='" + textBox1.Text + "',uye_soyad='" + textBox2.Text + "',uye_sinif='" + comboBox1.Text + "',uye_no='" + textBox4.Text + "',uye_adres='" + textBox5.Text + "',uye_telefon='" + maskedTextBox1.Text + "',uye_kayitucreti='" + textBox6.Text + "',uye_gorev='" + textBox7.Text + "',uye_resim='" + label8.Text + "'  where uye_id='" + _ID + "'", connection);


        guncelle.ExecuteNonQuery();
        connection.Close();
        MessageBox.Show("Kayıt Değiştirildi");
        this.Close();
        anasayfa a = Application.OpenForms["anasayfa"] as anasayfa;
        a.uyelerListele();
        a.kadroListele();
      }
      #region Büyük Harf/Küçük Harf
      private void textBox2_Leave(object sender, EventArgs e)
      {
        textBox2.Text = textBox2.Text.ToUpper();
      }

      private void textBox7_Leave(object sender, EventArgs e)
      {
        textBox7.Text = textBox7.Text.ToUpper();

      }

      private void textBox1_Leave(object sender, EventArgs e)
      {
        textBox1.Text=CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);
      }

      private void textBox5_Leave(object sender, EventArgs e)
      {
        textBox5.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text);
      }
      #endregion
  }
}
