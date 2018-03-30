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

namespace MetroUI
{
  public partial class demirbaslarForm : MetroForm
  {
      private int _ID = 0,islem=0;
    public demirbaslarForm(int pr1,int islem)
    {
        if (pr1 == 0 && islem == 0)
        {
            System.Windows.Forms.MessageBox.Show("Lütfen kayıt seçiniz." + pr1);
            //this.Close();

        }

        this.islem = islem;
        InitializeComponent();
        this._ID = pr1;
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");

    private void Demirbaşlar_Load(object sender, EventArgs e)
    {
        if (islem == 0)
        {
            connection.Open();

            SqlCommand bul = new SqlCommand("select * FROM Demirbaslar WHERE demirbas_id=@prmtr1", connection);
            bul.Parameters.AddWithValue("@prmtr1", _ID);

            SqlDataReader drEd = bul.ExecuteReader();
            if (drEd.Read())
            {
                textBox2.Text = drEd["demirbas_ad"].ToString();
                numericUpDown1.Text = drEd["demirbas_adet"].ToString();
                textBox4.Text = drEd["demirbas_cins"].ToString();
                dateTimePicker1.Text = drEd["demirbas_yil"].ToString();

            }

            connection.Close();

            btnDemirbasKaydet.Visible = false;
        }
        else
            btnDemirbasGuncelle.Visible = false;
    }
    private void btnCloseForm_Click(object sender, EventArgs e)
    {
      
    }

    private void btnMinimized_Click(object sender, EventArgs e)
    {
      
    }

    private void btnDemirbasKaydet_Click(object sender, EventArgs e)
    {
      
    }

    private void btnDemirbasGuncelle_Click(object sender, EventArgs e)
    {
        
    }

    private void btnDemirbasKaydet_Click_1(object sender, EventArgs e)
    {
      if (textBox2.Text == "" || numericUpDown1.Text == "0")
      {
        System.Windows.Forms.MessageBox.Show("LÜTFEN YILDIZLI ALANLARI DOLDURUNUZ !");
      }

      else
      {
        connection.Open();

        SqlCommand cekle = new SqlCommand("insert into Demirbaslar (demirbas_ad,demirbas_adet,demirbas_cins,demirbas_yil) values (@prmtr2,@prmtr3,@prmtr4,@prmtr5)", connection);

        cekle.Parameters.AddWithValue("@prmtr2", textBox2.Text);
        cekle.Parameters.AddWithValue("@prmtr3", numericUpDown1.Text);
        cekle.Parameters.AddWithValue("@prmtr4", textBox4.Text);
        cekle.Parameters.AddWithValue("@prmtr5", dateTimePicker1.Text);


        cekle.ExecuteNonQuery();
        connection.Close();

        System.Windows.Forms.MessageBox.Show("Kayıt Başarılı", "Bilgi");
        this.Close();
        anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
        a.demirbasListele();
      }
    }

    private void btnDemirbasGuncelle_Click_1(object sender, EventArgs e)
    {
      connection.Open();
      SqlCommand guncelle = new SqlCommand("update Demirbaslar set demirbas_ad='" + textBox2.Text + "' , demirbas_adet='" + numericUpDown1.Text + "', demirbas_cins='" + textBox4.Text + "' where demirbas_id='" + _ID + "'", connection);


      guncelle.ExecuteNonQuery();
      connection.Close();
      System.Windows.Forms.MessageBox.Show("Kayıt Güncellendi", "Bilgi");
      this.Close();
      anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
      a.demirbasListele();
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      textBox2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text);
    }

    private void textBox4_Leave(object sender, EventArgs e)
    {
      textBox4.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text);

    }
  }
}
