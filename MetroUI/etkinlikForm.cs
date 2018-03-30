using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;

namespace MetroUI
{
  public partial class etkinlikForm : MetroForm
  {
      private int _ID, islem;
    public etkinlikForm(int pr1 , int islem)
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
    private string IlkHarfleriBuyut(string metin)
    {
      System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
      System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
      return textInfo.ToTitleCase(metin);
    }
    private void etkinlikForm_Load(object sender, EventArgs e)
    {
        
        if (islem == 0 || islem==2)
        {
            if (islem == 2)
               btnEtkinlikGuncelle.Visible = false;

            connection.Open();

            SqlCommand bul = new SqlCommand("select * FROM Etkinlik WHERE etkinlik_id=@prmtr1", connection);
            bul.Parameters.AddWithValue("@prmtr1", _ID);


            SqlDataReader drEd = bul.ExecuteReader();
            if (drEd.Read())
            {
                txtAdi.Text = drEd["etkinlik_ad"].ToString();
                txtKonu.Text = drEd["etkinlik_konu"].ToString();
                txtKonusmacilar.Text = drEd["etkinlik_konusmaci"].ToString();
                txtYer.Text = drEd["etkinlik_yer"].ToString();
                dateTimePicker1.Text = drEd["etkinlik_tarih"].ToString();
            }
            connection.Close();
            btnEtkinlikKaydet.Visible = false;
        }
        else
            btnEtkinlikGuncelle.Visible = false;
    }

    private void btnCloseForm_Click(object sender, EventArgs e)
    {
    }

    private void btnMinimized_Click(object sender, EventArgs e)
    {
    }

    private void btnEtkinlikKaydet_Click(object sender, EventArgs e)
    {
        //etkinlik ekleme kodları buraya yazılacak

        if(txtAdi.Text=="" || txtKonu.Text=="" || txtYer.Text=="")
        {
            System.Windows.Forms.MessageBox.Show("LÜTFEN YILDIZLI ALANLARI DOLDURUNUZ !");
        }

        else
        {
            
            connection.Open();

            SqlCommand cekle = new SqlCommand("insert into Etkinlik (etkinlik_ad,etkinlik_konu,etkinlik_konusmaci,etkinlik_yer,etkinlik_tarih) values (@prmtr2,@prmtr3,@prmtr4,@prmtr5,@prmtr6)", connection);

            cekle.Parameters.AddWithValue("@prmtr2", txtAdi.Text);
            cekle.Parameters.AddWithValue("@prmtr3", txtKonu.Text);
            cekle.Parameters.AddWithValue("@prmtr4", txtKonusmacilar.Text);
            cekle.Parameters.AddWithValue("@prmtr5", txtYer.Text);
            cekle.Parameters.AddWithValue("@prmtr6", dateTimePicker1.Text);


            cekle.ExecuteNonQuery();
            connection.Close();

            System.Windows.Forms.MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
            this.Close();
            anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
            a.etkinlikListele();
        }
    }

    private void btnEtkinlikGuncelle_Click(object sender, EventArgs e)
    {
        connection.Open();
        SqlCommand guncelle = new SqlCommand("update Etkinlik set etkinlik_ad='"+txtAdi.Text+"' , etkinlik_konu='"+txtKonu.Text+"' , etkinlik_konusmaci='"+txtKonusmacilar.Text+"' , etkinlik_yer='"+txtYer.Text+"' , etkinlik_tarih='"+dateTimePicker1.Text+"' where etkinlik_id='" + _ID + "'", connection);

        guncelle.ExecuteNonQuery();
        connection.Close();
        System.Windows.Forms.MessageBox.Show("Kayıt Değiştirildi");
        this.Close();
        anasayfa a = System.Windows.Forms.Application.OpenForms["anasayfa"] as anasayfa;
        a.etkinlikListele();
    }

    private void txtAdi_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtAdi_Leave(object sender, EventArgs e)
    {
      txtAdi.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAdi.Text);

    }

    private void txtKonu_Leave(object sender, EventArgs e)
    {
      txtKonu.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtKonu.Text);

    }

    private void txtKonusmacilar_Leave(object sender, EventArgs e)
    {
      txtKonusmacilar.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtKonusmacilar.Text);

    }

    private void txtYer_Leave(object sender, EventArgs e)
    {
      txtYer.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtYer.Text);

    }
  }
}
