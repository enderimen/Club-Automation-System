using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
namespace MetroUI
{
  public partial class aktivasyonForm : MetroForm
  {
    public aktivasyonForm()
    {
      InitializeComponent();
    }
    int x;
    SqlConnection baglanti = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");       
    private void aktivasyonForm_Load(object sender, EventArgs e)
    {

    }
    string tempIpucu = "";
    private void button2_Click(object sender, EventArgs e)
    {
      SqlCommand command = new SqlCommand("SELECT kIpucu FROM login", baglanti);
      baglanti.Open();

      SqlDataReader dr = command.ExecuteReader();
      
      if (dr.HasRows)
      {
        while (dr.Read())
        {
          tempIpucu = dr["kIpucu"].ToString();
        }
      }
      else
      {
        System.Windows.Forms.MessageBox.Show("Kayıt Bulunamdı.");
      }
      baglanti.Close();
      
      if (txtipucu.Text.Trim()==tempIpucu)//db deki ipucunu kotrol ediyoruz...
      {
        aktivasyonKoduGonder();   
        panel2.Visible=false;
      }
      else
      {
        System.Windows.Forms.MessageBox.Show("Gereçersiz ipucu","Hata");
      }
    }
    
    public void aktivasyonKoduGonder()
    {
      SqlCommand command = new SqlCommand("SELECT kAdi,kEmail,pEmail,pEmailSifre FROM login", baglanti);
      baglanti.Open();

      SqlDataReader dr = command.ExecuteReader();
      string tempAdi = "";
      string tempEmail = "";
      string kimden ="";
      string sifre="";
      if (dr.HasRows)
      {
        while (dr.Read())
        {
          tempAdi= dr["kAdi"].ToString();
          tempEmail = dr["kEmail"].ToString();
          kimden = dr["pEmail"].ToString();
          sifre = dr["pEmailSifre"].ToString();
        }
      }
      else
      {
        System.Windows.Forms.MessageBox.Show("Kayıt Bulunamdı.");
      }
      baglanti.Close();

      login l= System.Windows.Forms.Application.OpenForms["login"] as login;

      if (l.username.Text == tempAdi)
      {
      #region Oto.Mail.Hesabı.Bilgileri
      #endregion 
        string kime = tempEmail;
        
        try
        {
          Random aktivasyonKodu = new Random();
          x = aktivasyonKodu.Next(100000, 999999);

          SmtpClient sc = new SmtpClient();
          sc.Port = 587;
          sc.Host = "smtp.gmail.com";
          sc.EnableSsl = true;
          sc.Credentials = new System.Net.NetworkCredential(kimden, sifre);
          MailMessage mesaj = new MailMessage(kimden, kime);

          mesaj.Subject = "Şifremi Unuttum!";
          mesaj.Body = "Şifrenizi sıfırlayabilmeniz için 6 haneli aktivasyon kodunuz : " + x + " İyi Günler.";

          sc.Send(mesaj);
        }
        catch (Exception ex)
        {
          System.Windows.Forms.MessageBox.Show("Lütfen bir kulanıcı adı giriniz.\nHata: " + ex.Message);
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (aktivasyon.Text == x.ToString())
      {
        System.Windows.Forms.MessageBox.Show("Doğrulama Başarılı!");
        sifreIslemleriForm sifre=new sifreIslemleriForm();
        sifre.Show();
        this.Hide();
      }
      else
      {
        System.Windows.Forms.MessageBox.Show("Doğrulma Yapılamadı.");
      }
    }
  }
}
