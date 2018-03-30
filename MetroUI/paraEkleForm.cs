using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;
namespace MetroUI
{
  public partial class paraEkleForm : MetroForm
  {
      private int _ID, islem;

      public paraEkleForm(int pr1, int islem)
    {
        if (pr1 == 0 && islem == 0)
        {
            MessageBox.Show("Lütfen kayıt seçiniz." + pr1);
        }

        this.islem = islem;
        InitializeComponent();
        this._ID = pr1;
    }
      SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");

    private void btnEtkinlikKaydet_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "")
        {
          System.Windows.Forms.MessageBox.Show("LÜTFEN YILDIZLI ALANLARI DOLDURUNUZ");
        }
        else
        {
            int kalanbutce = 0;
            connection.Open();

            SqlCommand bul = new SqlCommand("select kalan_butce FROM Kasa WHERE kasa_id=(select TOP 1 kasa_id from Kasa ORDER BY kasa_id DESC )", connection);
           
            SqlDataReader drEd = bul.ExecuteReader();
            
                if (drEd.Read())
                {
                  kalanbutce = Convert.ToInt32(drEd["kalan_butce"]);
                }
                    
                drEd.Close();

            SqlCommand cekle = new SqlCommand("insert into Kasa (kasa_turu,kasa_tutar,kasa_aciklama,kasa_yetkili,kasa_tarihi,kalan_butce) values (@prmtr2,@prmtr3,@prmtr4,@prmtr5,@prmtr6,@prmtr7)", connection);

            kalanbutce += Convert.ToInt32(textBox1.Text);
            cekle.Parameters.AddWithValue("@prmtr2", "EKLENEN");
            cekle.Parameters.AddWithValue("@prmtr3", textBox1.Text);
            cekle.Parameters.AddWithValue("@prmtr4", textBox5.Text);
            cekle.Parameters.AddWithValue("@prmtr5", textBox2.Text);
            cekle.Parameters.AddWithValue("@prmtr6", dateTimePicker1.Text);
            cekle.Parameters.AddWithValue("@prmtr7",kalanbutce);
            cekle.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
            this.Close();

            anasayfa a = Application.OpenForms["anasayfa"] as anasayfa;
            a.kasaListele();

        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        connection.Open();
        SqlCommand guncelle = new SqlCommand("update Kasa set kasa_aciklama='" + textBox5.Text + "' , kasa_yetkili='" + textBox2.Text + "' , kasa_tarihi='" + dateTimePicker1.Text + "' where kasa_id='" + _ID + "'", connection);


        guncelle.ExecuteNonQuery();
        connection.Close();
        System.Windows.Forms.MessageBox.Show("Kayıt Değiştirildi");
        this.Close();

        anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
        a.kasaListele();
    }

    private void paraEkleForm_Load(object sender, EventArgs e)
    {
        if (islem == 0)
        {
            btnEtkinlikKaydet.Visible = false;
            connection.Open();

            SqlCommand bul = new SqlCommand("select * FROM Kasa WHERE kasa_id=@prmtr1", connection);
            bul.Parameters.AddWithValue("@prmtr1", _ID);


            SqlDataReader drEd = bul.ExecuteReader();
            if (drEd.Read())
            {
                textBox5.Text = drEd["kasa_aciklama"].ToString();
                textBox2.Text = drEd["kasa_yetkili"].ToString();
                dateTimePicker1.Text = drEd["kasa_tarihi"].ToString();
            }
            connection.Close();
        }
        else
            button1.Visible = false;
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;
        if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
        {
            e.Handled = true;
        }
    }

    private void textBox1_MouseClick(object sender, MouseEventArgs e)
    {
        if(islem==0)
        MessageBox.Show("Parayı Düzenleyemezsiniz!");
    }

    private void textBox5_Leave(object sender, EventArgs e)
    {
      textBox5.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text);
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      textBox2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text);
    }
  }
}
/*
             yeniKayitForm l= System.Windows.Forms.Application.OpenForms["yeniKayitForm"] as yeniKayitForm;
            
            int kayitUcreti;//yeni kayit taki kayitUcreti değerini atanacak
 */