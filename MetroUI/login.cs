using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace MetroUI
{
  public partial class login : MetroForm
  {
    public login()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");
    SqlCommand komut = new SqlCommand();
    SqlDataAdapter adtr = new SqlDataAdapter();
    DataSet ds = new DataSet();        
      
    

    private void button1_Click(object sender, EventArgs e)
    {
    log_in();
    }
    private void login_Load(object sender, EventArgs e)
    {

    }
    private void log_in()
    {
      try
      {
        baglanti.Open();
        SqlCommand sorgu = new SqlCommand("SELECT * FROM login order by kAdi,kSifre", baglanti);
        SqlDataReader datare;
        datare = sorgu.ExecuteReader();
        while (datare.Read())
        {
          string a = Convert.ToString(username.Text);
          string b = Convert.ToString(userpassword.Text);

          if (a == datare[1].ToString() && b == datare[2].ToString())
          {
            anasayfa anaform = new anasayfa();
            anaform.Show();
            this.Hide();
          }
          else
          {
            System.Windows.Forms.MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA");
          }
        }
        datare.Close();
        baglanti.Close();
      }
      catch (Exception hata)
      {
        System.Windows.Forms.MessageBox.Show(hata.Message);
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        //karakteri göster.
        userpassword.PasswordChar = '\0';
      }
      //değilse karakterlerin yerine • koy.
      else
      {
        userpassword.PasswordChar = '⚫';
      }
    }

    private void btnCloseForm_Click(object sender, EventArgs e)
    {
    }

    private void btnMinimized_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
      try
      {
        baglanti.Open();
        SqlCommand sorgu = new SqlCommand("SELECT * FROM login WHERE ID=1", baglanti);
        SqlDataReader datare;
        datare = sorgu.ExecuteReader();
        while (datare.Read())
        {
          string a = Convert.ToString(username.Text);

          if (a == datare[1].ToString())
          {
            aktivasyonForm ak = new aktivasyonForm();
            ak.Show();
          }
          else
          {
            System.Windows.Forms.MessageBox.Show("Kullanıcı adı hatalı", "HATA");
          }
        }
        datare.Close();
        baglanti.Close();
      }
      catch (Exception hata)
      {
        System.Windows.Forms.MessageBox.Show(hata.Message);
      } 
    }
  }
}
