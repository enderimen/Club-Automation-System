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
  public partial class adminBilgileri : MetroForm
  {
    public adminBilgileri()
    {
      InitializeComponent();
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");       
    private void adminBilgileri_Load(object sender, EventArgs e)
    {
      goster();  
    }

    private void goster()
    {
      SqlCommand command = new SqlCommand("SELECT kAdi,kEmail,kIpucu,pEmail,pEmailSifre FROM login", connection);
      connection.Open();

      SqlDataReader dr=command.ExecuteReader();
      
      if (dr.HasRows)
      {
        while (dr.Read())
        {
          username.Text = dr["kAdi"].ToString();
          email.Text = dr["kEmail"].ToString();
          ipucu.Text = dr["kIpucu"].ToString();
          pemailsifre.Text = dr["pEmailSifre"].ToString();
          pMail.Text = dr["pEmail"].ToString();
        }   
      } 
      else
      {
        System.Windows.Forms.MessageBox.Show("Kayıt Bulunamdı.");
      }
      connection.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
          SqlCommand command = new SqlCommand("UPDATE login SET kAdi=@Adi , kEmail=@email, kIpucu=@ipucu,pEmail=@pmail,pEmailSifre=@mailSifre WHERE ID=1", connection);
        
          command.Parameters.AddWithValue("@Adi", username.Text);
          command.Parameters.AddWithValue("@email", email.Text.Trim());
          command.Parameters.AddWithValue("@ipucu", ipucu.Text);
          command.Parameters.AddWithValue("@pmail", pMail.Text.Trim());
          command.Parameters.AddWithValue("@mailSifre", pemailsifre.Text.Trim());

          int etkilenen = 0;
          
          connection.Open();
          etkilenen = command.ExecuteNonQuery();
          connection.Close();

          if (etkilenen > 0)
          {
            System.Windows.Forms.MessageBox.Show("Üye Bilgileri Güncellendi!", "Bigi");
            goster();
            this.Close();
          }
          else
          {
            System.Windows.Forms.MessageBox.Show("Güncelleme Gerçekleşmedi", "Hata");
          }
        }
      catch (Exception hata)
      {
        System.Windows.Forms.MessageBox.Show("Hata\n" + hata.Message);
      }
      }
    }
  }
