using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MetroUI
{
  public partial class sifreIslemleriForm : MetroForm
  {
    public sifreIslemleriForm()
    {
      InitializeComponent();
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true;MultipleActiveResultSets=True");
    #region şifre göster işareti
    
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox2.Checked)
      {
        //karakteri göster.
        yeniSifre.PasswordChar = '\0';
      }
      //değilse karakterlerin yerine • koy.
      else
      {
        yeniSifre.PasswordChar = '⚫';
      }
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox3.Checked)
      {
        //karakteri göster.
        tyeniSifre.PasswordChar = '\0';
      }
      //değilse karakterlerin yerine • koy.
      else
      {
        tyeniSifre.PasswordChar = '⚫';
      }
    }
    #endregion
    
    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (connection.State != ConnectionState.Open)
        {
          connection.Open();   
        }
        SqlCommand sorgu = new SqlCommand("SELECT * FROM login order by kSifre", connection);
        SqlDataReader datare = sorgu.ExecuteReader();
        
        while (datare.Read())
        {
          string a = Convert.ToString(username.Text);
          string b = Convert.ToString(yeniSifre.Text);
          string c = Convert.ToString(tyeniSifre.Text);


          if (a == datare[1].ToString() && b==c)
          {

            SqlCommand komut = new SqlCommand("UPDATE login SET kSifre=" + yeniSifre.Text + " WHERE ID=1", connection);
            int etkilenen=komut.ExecuteNonQuery();
           
            if (etkilenen>0)
            {
              MessageBox.Show("Şifreniz Değiştirildi", "BİLGİ"); this.Close(); 
            }
            
            yeniSifre.Text = "";
            tyeniSifre.Text = "";
            checkBox2.Checked = false;
            checkBox3.Checked = false;
          }
          else
          {
            MessageBox.Show("Kullanıcı Adı/Şifre Hatalı", "HATA");
            yeniSifre.Text = "";
            tyeniSifre.Text = "";
          }
          
        }
        connection.Close();
      }
      catch (Exception hata)
      {
            MessageBox.Show(hata.Message);
      } 
    }

    private void sifreIslemleriForm_Load(object sender, EventArgs e)
    {

    }
  }
}
