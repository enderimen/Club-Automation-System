using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;


namespace MetroUI
{
  public partial class projeForm : MetroForm
  {
      private int _ID, islem;

    public projeForm(int pr1,int islem)
    {

        if (pr1 == 0 && islem == 0)
        {
          System.Windows.Forms.MessageBox.Show("Lütfen kayıt seçiniz." + pr1);
            
        }

        this.islem = islem;
        InitializeComponent();
        this._ID = pr1;
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");

    private void demirbaslar_Load(object sender, EventArgs e)
    {
        if (islem == 0 || islem ==2)
        {
            if (islem == 2)
                btnProjeGuncelle.Visible = false;
            
            connection.Open();




            SqlCommand bul = new SqlCommand("select * FROM Projeler WHERE proje_id=@prmtr1", connection);
            bul.Parameters.AddWithValue("@prmtr1", _ID);


            SqlDataReader drEd = bul.ExecuteReader();
            if (drEd.Read())
            {
                textBox2.Text = drEd["proje_ad"].ToString();
                textBox3.Text = drEd["proje_konu"].ToString();
                textBox4.Text = drEd["proje_aciklama"].ToString();
                dateTimePicker1.Text = drEd["proje_yil"].ToString();
                textBox7.Text = drEd["yapan_ad"].ToString();
                textBox6.Text = drEd["yapan_soyad"].ToString();
                comboBox1.Text = drEd["yapan_sinif"].ToString();
                textBox5.Text = drEd["yapan_no"].ToString();
                

            }
            connection.Close();
            btnProjeKaydet.Visible = false;
        }
        else
        {
            btnProjeGuncelle.Visible = false;
        }
    }

    private void btnCloseForm_Click(object sender, EventArgs e)
    {
    }

    private void btnMinimized_Click(object sender, EventArgs e)
    {
    }

    private void btnProjeKaydet_Click(object sender, EventArgs e)
    {
        if (textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || textBox6.Text == "" || textBox5.Text == "")
        {
          System.Windows.Forms.MessageBox.Show("LÜTFEN YILDIZLI ALANLARI DOLDURUNUZ");
        }

        else
        {
            connection.Open();

            SqlCommand cekle = new SqlCommand("insert into Projeler (proje_ad,proje_konu,proje_aciklama,proje_yil,yapan_ad,yapan_soyad,yapan_sinif,yapan_no) values (@prmtr2,@prmtr3,@prmtr4,@prmtr5,@prmtr6,@prmtr7,@prmtr8,@prmtr9)", connection);

            cekle.Parameters.AddWithValue("@prmtr2", textBox2.Text);
            cekle.Parameters.AddWithValue("@prmtr3", textBox3.Text);
            cekle.Parameters.AddWithValue("@prmtr4", textBox4.Text);
            cekle.Parameters.AddWithValue("@prmtr5", dateTimePicker1.Text);
            cekle.Parameters.AddWithValue("@prmtr6", textBox7.Text);
            cekle.Parameters.AddWithValue("@prmtr7", textBox6.Text);
            cekle.Parameters.AddWithValue("@prmtr8", comboBox1.Text);
            cekle.Parameters.AddWithValue("@prmtr9", textBox5.Text);

            cekle.ExecuteNonQuery();
            connection.Close();

            System.Windows.Forms.MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
            this.Close();
            anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
            a.projeListele();
        }
    }

    private void btnProjeGuncelle_Click(object sender, EventArgs e)
    {
        connection.Open();
        SqlCommand guncelle = new SqlCommand("update Projeler set proje_ad='"+textBox2.Text+"', proje_konu='"+textBox3.Text+"' , proje_aciklama='"+textBox4.Text+"', proje_yil='"+dateTimePicker1.Text+"' , yapan_ad='"+textBox7.Text+"' , yapan_soyad='"+textBox6.Text+"' , yapan_sinif='"+comboBox1.Text+"' , yapan_no='"+textBox5.Text+"' where proje_id='" + _ID + "'", connection);


        guncelle.ExecuteNonQuery();
        connection.Close();
        System.Windows.Forms.MessageBox.Show("Kayıt Değiştirildi");
        this.Close();
        anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
        a.projeListele();            
    }

    private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;
        if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
        {
            e.Handled = true;
        }
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      textBox2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text);

    }

    private void textBox3_Leave(object sender, EventArgs e)
    {
      textBox3.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox3.Text);

    }

    private void textBox4_Leave(object sender, EventArgs e)
    {
      textBox4.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text);

    }

    private void textBox7_Leave(object sender, EventArgs e)
    {
      textBox7.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox7.Text);

    }

    private void textBox6_Leave(object sender, EventArgs e)
    {
      textBox6.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox6.Text);
    }
  }
}
