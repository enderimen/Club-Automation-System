using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;

namespace MetroUI
{
  public partial class kimlikForm : MetroForm
  {

      private int _ID;
    public kimlikForm(int pr1)
      {
          if (pr1 == 0)
          {
            System.Windows.Forms.MessageBox.Show("Lütfen kayıt seçiniz." + pr1);
              //this.Close();
          
          }
          
              InitializeComponent();
              this._ID = pr1;
     
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true");


    private void kimlik_Load(object sender, EventArgs e)
    {
                connection.Open();

                SqlCommand bul = new SqlCommand("select * FROM Uyeler WHERE uye_id=@prmtr1", connection);
                bul.Parameters.AddWithValue("@prmtr1", _ID);


                SqlDataReader drEd = bul.ExecuteReader();
                if (drEd.Read())
                {
                    label18.Text = drEd["uye_ad"].ToString();
                    label17.Text = drEd["uye_soyad"].ToString();
                    label16.Text = drEd["uye_sinif"].ToString();
                    label15.Text = drEd["uye_no"].ToString();
                    label12.Text = drEd["uye_adres"].ToString();
                    label14.Text = drEd["uye_telefon"].ToString();
                    label13.Text = drEd["uye_kayitucreti"].ToString();
                    label11.Text = drEd["uye_gorev"].ToString();
                    label8.Text = drEd["uye_kayityil"].ToString();
                    label19.Text=drEd["uye_resim"].ToString();
                    pictureBox1.ImageLocation=label19.Text;
                }
    }
    private void btnMinimized_Click(object sender, EventArgs e)
    {
    }

    private void btnCloseForm_Click(object sender, EventArgs e)
    {
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        this.Close();
    }
  }
}
