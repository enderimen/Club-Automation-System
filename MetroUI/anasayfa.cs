using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
namespace MetroUI
{
  public partial class anasayfa : MetroForm
  {
    public anasayfa()
    {
      InitializeComponent();
    }
    SqlConnection connection = new SqlConnection("server=ACER-E1-571G\\SQLEXPRESS01;Database=KlupOtomasyon;Integrated Security=true;MultipleActiveResultSets=True");

    private void Form1_Load(object sender, EventArgs e)
    {
       toolStripTextBox1.Text = "Ara";
       toolStripStatusLabel2.Text=DateTime.Today.ToLongDateString();
       uyelerListele();
    }


    public void excelaktar(DataGridView data)
    {
        saveFileDialog1.InitialDirectory = "C:";
        saveFileDialog1.Title = "Excel Dosyasını Buraya Kaydet";
        saveFileDialog1.FileName = "";
        saveFileDialog1.Filter = "Excel Dosyası|*.xls";
        if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);

            excel.Columns.ColumnWidth = 20;

            for (int i = 1; i < data.Columns.Count + 1; i++)
            {
                excel.Cells[1, i] = data.Columns[i - 1].HeaderText;
            }


            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value;
                }
            }

            excel.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
            excel.ActiveWorkbook.Saved = true;
            excel.Quit();
        }
    }

      void sil(DataGridView datagrid , String tablo,String id)
      {
          int _ID = 0;

          try
          {
              _ID = Convert.ToInt32(datagrid.SelectedRows[0].Cells[0].Value.ToString());
          }
          catch { }


          if (_ID == 0)
          {
              MessageBox.Show("Kayıt Seçiniz.");
          }
          else
          {
              
              connection.Open();
              DialogResult r = System.Windows.Forms.MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Dikkat", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);
              if (DialogResult.Yes == r)
              {
                SqlCommand sil = new SqlCommand("DELETE FROM "+tablo+" WHERE "+id+"=@prmtr1", connection);

                sil.Parameters.AddWithValue("@prmtr1", _ID);
                sil.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Kayıt Silindi!","Bilgi");
              }
              else{/*Hiçbir şey yapma*/}
              connection.Close();
          }
      }

    private void btnEtkinlik_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage5;
      //kayitgetir(datagirdetkinlikler,"Etkinlikler");


      etkinlikListele();
      
    }

    public void etkinlikListele()
    {
      connection.Open();

      SqlDataAdapter adaptor = new SqlDataAdapter("select etkinlik_id as id , etkinlik_ad as Etkinlik , etkinlik_konu as Konusu , Etkinlik_konusmaci as Konuşmacılar , etkinlik_yer as Yer , etkinlik_tarih as Tarih from Etkinlik", connection);

      DataSet can = new DataSet();

      adaptor.Fill(can, "xx");

      datagirdetkinlikler.DataSource = can.Tables[0];
      datagirdetkinlikler.Columns[0].Width = 35;
      datagirdetkinlikler.Columns[5].Width = 75;
      connection.Close();
    }
    #region Tab Click

    private void uyeler_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage1;
    }
    private void kadro_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab=tabPage2;
    }
    private void demirbas_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage3;
    }

    private void project_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage4;
    }

    private void etkinlik_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage5;
    }
    #endregion
    private void btnKayit_Click(object sender, EventArgs e)
    {
      yeniKayitForm f = new yeniKayitForm(1,1);
      f.ShowDialog();
    }

    private void btnUyeler_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab=tabPage1;
     // kayitgetir(datagriduyeler,"Uyeler");
      uyelerListele();
    }

    public void uyelerListele()
    {
      if (connection.State!=ConnectionState.Open)
      {
          connection.Open();
      }
      SqlCommand toplamUyeCmd=new SqlCommand("SELECT t=COUNT(*) FROM Uyeler",connection);
      SqlDataReader dr_toplamUye=toplamUyeCmd.ExecuteReader();
      
      if (dr_toplamUye.Read())
      {
        label3.Text="Toplam Üye Sayısı: "+dr_toplamUye["t"].ToString();
      }

      SqlDataAdapter adaptor = new SqlDataAdapter("select uye_id as id ,uye_ad as Ad,uye_soyad as Soyad,uye_sinif as Sınıf,uye_no as Numara,uye_kayityil as [Kayıt Yılı] from Uyeler", connection);

      DataSet can = new DataSet();

      adaptor.Fill(can, "xx");

      datagriduyeler.DataSource = can.Tables[0];
      datagriduyeler.Columns[0].Width = 35;
      datagriduyeler.Columns[5].Width = 75;
      connection.Close();
    }

    private void btnDemirbas_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage3;
     // kayitgetir(datagirddemirbas, "Demirbaslar");
      demirbasListele();
       
    }

    public void demirbasListele()
    {
      connection.Open();

      SqlDataAdapter adaptor = new SqlDataAdapter("select demirbas_id as id,demirbas_ad as Ad , demirbas_adet as Adet , demirbas_cins as Cins, demirbas_yil as Tarih from Demirbaslar", connection);

      DataSet can = new DataSet();

      adaptor.Fill(can, "xx");

      datagirddemirbas.DataSource = can.Tables[0];
      datagirddemirbas.Columns[0].Width = 35;
      datagirddemirbas.Columns[1].Width = 125;
      datagirddemirbas.Columns[3].Width = 125;
      datagirddemirbas.Columns[4].Width = 125;

      connection.Close();
    }

    private void btnProjeler_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage4;
      //kayitgetir(datagirdprojeler, "Projeler)
      projeListele();
    }

    public void projeListele()
    {
      connection.Open();

      SqlDataAdapter adaptor = new SqlDataAdapter("select proje_id as id ,proje_ad as Proje , proje_konu as Konusu , proje_yil as Yılı , yapan_ad as [Sahibi Ad] , yapan_no as No from Projeler", connection);

      DataSet can = new DataSet();

      adaptor.Fill(can, "xx");

      datagirdprojeler.DataSource = can.Tables[0];
      datagirdprojeler.Columns[0].Width = 35;
      datagirdprojeler.Columns[5].Width = 75;

      connection.Close();
    }

    private void btnRaporlar_Click(object sender, EventArgs e)
    {
      //Rapor formu açılacak
      MessageBox.Show("Rapor Modülü henüz oluşturulmadı. ","Bilgi");
    }

    private void btnKadro_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedTab = tabPage2;

      kadroListele();
    }

    public void kadroListele()
    {
      connection.Open();

      SqlDataAdapter adaptor = new SqlDataAdapter("select uye_id as id ,uye_ad as Ad,uye_soyad as Soyad,uye_sinif as Sınıf,uye_no as Numara,uye_gorev as Görevi from Uyeler where uye_gorev != '' ", connection); //LIKE _'%'"

      DataSet can = new DataSet();

      adaptor.Fill(can, "xx");

      datagirdkadro.DataSource = can.Tables[0];
      datagirdkadro.Columns[0].Width = 35;
      datagirdkadro.Columns[5].Width = 75;

      connection.Close();
    }
    #region Button Hover
    
    private void btnUyeler_MouseEnter(object sender, EventArgs e)
    {
      btnUyeler.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnKayit_MouseEnter(object sender, EventArgs e)
    {
      btnKayit.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnDemirbas_MouseEnter(object sender, EventArgs e)
    {
      btnDemirbas.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnProjeler_MouseEnter(object sender, EventArgs e)
    {
      btnProjeler.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnRaporlar_MouseEnter(object sender, EventArgs e)
    {
      btnRaporlar.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnKadro_MouseEnter(object sender, EventArgs e)
    {
      btnKadro.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnEtkinlik_MouseEnter(object sender, EventArgs e)
    {
      btnEtkinlik.BackColor = Color.FromArgb(28, 44, 60);
    }

    private void btnUyeler_MouseLeave(object sender, EventArgs e)
    {
      btnUyeler.BackColor = Color.FromArgb(44, 62, 80);
    }

    private void btnKayit_MouseLeave(object sender, EventArgs e)
    {
      btnKayit.BackColor = Color.FromArgb(44, 62, 80);
    }

    private void btnDemirbas_MouseLeave(object sender, EventArgs e)
    {
      btnDemirbas.BackColor = Color.FromArgb(44, 62, 80);
    }

    private void btnProjeler_MouseLeave(object sender, EventArgs e)
    {
      btnProjeler.BackColor = Color.FromArgb(44, 62, 80);
    }

    private void btnRaporlar_MouseLeave(object sender, EventArgs e)
    {
      btnRaporlar.BackColor = Color.FromArgb(44, 62, 80);
    }

    private void btnKadro_MouseLeave(object sender, EventArgs e)
    {
      btnKadro.BackColor = Color.FromArgb(44, 62, 80);
    }

    private void btnEtkinlik_MouseLeave(object sender, EventArgs e)
    {
      btnEtkinlik.BackColor = Color.FromArgb(44, 62, 80);
    }
    #endregion
    
    
    private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      sifreIslemleriForm sifreDegistir=new sifreIslemleriForm();
      sifreDegistir.ShowDialog();
    }

    private void paraEkleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      paraEkleForm paraEkle=new paraEkleForm(1,1);
      paraEkle.ShowDialog();
    }

    private void harcamalarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      harcamalarForm harcananForm=new harcamalarForm(1,1);
      harcananForm.ShowDialog();
    }
   int kalanbutce;
    private void hesapDurumuToolStripMenuItem_Click(object sender, EventArgs e)
    { 
      tabControl1.SelectedTab = tabPage6;
      kasaListele();
    }

    public void kasaListele()
    {
        connection.Open();
        kalanbutce = 0;
        //Alttaki kodda eğer üye silinirse parasıda siliniyor.
        //------------------------------------------------------
       /* SqlCommand cmd_kasa = new SqlCommand("SELECT c=SUM(uye_kayitucreti)FROM Uyeler", connection);
        SqlDataReader dr_kasa=cmd_kasa.ExecuteReader();
        
        int toplamUcret=0;

        if (dr_kasa.Read())
        {
           toplamUcret=Convert.ToInt32(dr_kasa["c"]);
        }*/
        //-------------------------------------------------------
        SqlCommand bul = new SqlCommand("select kalan_butce FROM Kasa WHERE kasa_id=(select TOP 1 kasa_id from Kasa ORDER BY kasa_id DESC )", connection);

        SqlDataReader drEd = bul.ExecuteReader();
        if (drEd.Read())
        {
           kalanbutce = Convert.ToInt32(drEd["kalan_butce"]);
        }
        drEd.Close();

      SqlDataAdapter adaptor = new SqlDataAdapter("select kasa_id as id ,kasa_turu as İslem , kasa_tutar as Tutar ,kasa_alinan as Alınan , kasa_aciklama as Açıklama , kasa_yetkili as Yetkili , kasa_tarihi as Tarih from Kasa", connection);


      butce.Text = kalanbutce + " ₺";
      DataSet can = new DataSet();

      adaptor.Fill(can, "xx");
      
      datagridkasa.DataSource = can.Tables[0];
      datagridkasa.Columns[0].Width = 30;
      datagridkasa.Columns[1].Width = 65;
      datagridkasa.Columns[2].Width = 45;
      datagridkasa.Columns[6].Width = 70;
      connection.Close();
    }

    private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      hakkindaForm hakkında=new hakkindaForm();
      hakkında.ShowDialog();
    }

    private void datagriduyeler_MouseClick(object sender, MouseEventArgs e)
    {
    
    }    

    private void bilgilerToolStripMenuItem_Click(object sender, EventArgs e)
    {      
        if(tabControl1.SelectedTab==tabPage1)
        {
             int _ID = 0;

        try
        {
            _ID = Convert.ToInt32(datagriduyeler.SelectedRows[0].Cells[0].Value.ToString());
        }
        catch { }

            kimlikForm kimlik = new kimlikForm(_ID);
            kimlik.Show();
        }

        if (tabControl1.SelectedTab == tabPage2)
        {
            int _ID = 0;

            try
            {
                _ID = Convert.ToInt32(datagirdkadro.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }

            kimlikForm kimlik = new kimlikForm(_ID);
            kimlik.Show();
        }

        if (tabControl1.SelectedTab == tabPage4)
        {
            int _ID = 0;

            try
            {
                _ID = Convert.ToInt32(datagirdprojeler.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }

            projeForm proje = new projeForm(_ID,2);
            proje.Show();
        }

        if (tabControl1.SelectedTab == tabPage5)
        {
            int _ID = 0;

            try
            {
                _ID = Convert.ToInt32(datagirdetkinlikler.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }

            etkinlikForm etkinlik = new etkinlikForm(_ID, 2);
            etkinlik.Show();
        }
    }

    private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
    {
         int _ID = 0;


         if (tabControl1.SelectedTab == tabPage1)
        {
            try
            {
                _ID = Convert.ToInt32(datagriduyeler.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }
            yeniKayitForm yenikayit = new yeniKayitForm(_ID, 0);
            yenikayit.Show();
        }
        
        if(tabControl1.SelectedTab == tabPage3)
        {
            try
            {
                _ID = Convert.ToInt32(datagirddemirbas.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }
           
            demirbaslarForm demirbaslar = new demirbaslarForm(_ID,0);
            demirbaslar.Show();   
        }

        if(tabControl1.SelectedTab==tabPage4)
        {
            try
            {
                _ID = Convert.ToInt32(datagirdprojeler.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }
            
            projeForm proje = new projeForm(_ID,0);
            proje.Show();
          
        }


        if (tabControl1.SelectedTab == tabPage5)
        {
            try
            {
                _ID = Convert.ToInt32(datagirdetkinlikler.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }

            etkinlikForm etkinlik = new etkinlikForm(_ID,0);
            etkinlik.Show();
          
        }

        if (tabControl1.SelectedTab == tabPage2)
        {
            try
            {
                _ID = Convert.ToInt32(datagirdkadro.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch { }
            yeniKayitForm yenikayit = new yeniKayitForm(_ID, 0);
            yenikayit.Show();
            
        }

        if (tabControl1.SelectedTab == tabPage6)
        {
            try
            {
                _ID = Convert.ToInt32(datagridkasa.SelectedRows[0].Cells[0].Value.ToString());
                
                if (datagridkasa.SelectedRows[0].Cells[1].Value.ToString() == "")
                {
                  MessageBox.Show("Kayıt mevcut değil.", "Bilgi");
                }
                if (datagridkasa.SelectedRows[0].Cells[1].Value.ToString() == "HARCAMA")
                {
                  harcamalarForm harcama = new harcamalarForm(_ID, 0);
                  harcama.Show();
                }
                if (datagridkasa.SelectedRows[0].Cells[1].Value.ToString() == "EKLENEN")
                {
                  paraEkleForm paraekle = new paraEkleForm(_ID, 0);
                  paraekle.Show();
                }
            }
            catch { }
        }

    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if(tabControl1.SelectedTab==tabPage1)
        {
            sil(datagriduyeler,"Uyeler","uye_id");
            uyelerListele();
        }
        if(tabControl1.SelectedTab==tabPage2)
        {
            sil(datagirdkadro,"Uyeler","uye_id");
            kadroListele();
        }
        if (tabControl1.SelectedTab == tabPage3)
        {
            sil(datagirddemirbas,"demirbaslar","demirbas_id");
            demirbasListele();
        }
        if (tabControl1.SelectedTab == tabPage4)
        {
            sil(datagirdprojeler,"projeler","proje_id");
            projeListele();

        }
        if (tabControl1.SelectedTab == tabPage5)
        {
            sil(datagirdetkinlikler,"etkinlik","etkinlik_id");
            etkinlikListele();
        }
        if (tabControl1.SelectedTab == tabPage6)
        {
          sil(datagridkasa, "Kasa", "kasa_id");
          kasaListele();
        }
    }
    private void yeniKayıtToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        demirbaslarForm demirbaslarform = new demirbaslarForm(1, 1);
        demirbaslarform.Show();
    }

    private void yeniKayıtToolStripMenuItem2_Click(object sender, EventArgs e)
    {
        projeForm projeform = new projeForm(1, 1);
        projeform.Show(); ;
    }

    private void yeniKayıtToolStripMenuItem3_Click(object sender, EventArgs e)
    {
        etkinlikForm etkinlikform = new etkinlikForm(1, 1);
        etkinlikform.Show();
    }

    private void yeniKAyıtToolStripMenuItem_Click(object sender, EventArgs e)
    {       
        yeniKayitForm yenikayit = new yeniKayitForm(1, 1);
        yenikayit.Show();
    }
    private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (tabControl1.SelectedTab == tabPage1)
        {

            connection.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter("select uye_id as id ,uye_ad as Ad,uye_soyad as Soyad,uye_sinif as Sınıf,uye_no as Numara,uye_kayityil as [Kayıt Yılı] from Uyeler where uye_ad LIKE '%" + toolStripTextBox1.Text + "%'", connection);

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            datagriduyeler.DataSource = can.Tables[0];
            datagriduyeler.Columns[0].Width = 35;
            datagriduyeler.Columns[5].Width = 75;
            connection.Close();

        }

        if(tabControl1.SelectedTab==tabPage2)
        {

            connection.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter("select uye_id as id ,uye_ad as Ad,uye_soyad as Soyad,uye_sinif as Sınıf,uye_no as Numara,uye_gorev as Görevi from Uyeler where uye_gorev != '' and uye_gorev LIKE '%"+ toolStripTextBox1.Text + "%'", connection);

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            datagirdkadro.DataSource = can.Tables[0];
            datagirdkadro.Columns[0].Width = 35;
            datagirdkadro.Columns[5].Width = 75;

            connection.Close();

        }

        if(tabControl1.SelectedTab==tabPage3)
        {

            connection.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter("select demirbas_id as id,demirbas_ad as Ad , demirbas_adet as Adet , demirbas_cins as Cins, demirbas_yil as Tarih from Demirbaslar where demirbas_ad LIKE '%" + toolStripTextBox1.Text + "%'", connection);

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            datagirddemirbas.DataSource = can.Tables[0];
            datagirddemirbas.Columns[0].Width = 30;
            datagirddemirbas.Columns[1].Width = 127;
            datagirddemirbas.Columns[3].Width = 127;
            datagirddemirbas.Columns[4].Width = 125;

            connection.Close();
        }

        if(tabControl1.SelectedTab==tabPage4)
        {
      
            
            connection.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter("select proje_id as id ,proje_ad as Proje , proje_konu as Konusu , proje_yil as Yılı , yapan_ad as [Sahibi Ad] , yapan_no as No from Projeler where proje_ad LIKE '%" + toolStripTextBox1.Text + "%'", connection);

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            datagirdprojeler.DataSource = can.Tables[0];
            datagirdprojeler.Columns[0].Width = 35;
            datagirdprojeler.Columns[5].Width = 75;

            connection.Close();
        }

        if(tabControl1.SelectedTab==tabPage5)
        {
         
            connection.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter("select etkinlik_id as id , etkinlik_ad as Etkinlik , etkinlik_konu as Konusu , etkinlik_konusmaci as Konuşmacılar , etkinlik_yer as Yer , etkinlik_tarih as Tarih from Etkinlik where etkinlik_ad LIKE '%" + toolStripTextBox1.Text + "%'", connection);

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            datagirdetkinlikler.DataSource = can.Tables[0];
            datagirdetkinlikler.Columns[0].Width = 35;
            datagirdetkinlikler.Columns[5].Width = 75;
            connection.Close();
        }


        if (tabControl1.SelectedTab == tabPage6)
        {

            connection.Open();


            SqlDataAdapter adaptor = new SqlDataAdapter("select kasa_id as id ,kasa_turu as İslem , kasa_tutar as Tutar ,kasa_alinan as Alınan , kasa_aciklama as Açıklama , kasa_yetkili as Yetkili , kasa_tarihi as Tarih from Kasa where kasa_alinan LIKE '%"+toolStripTextBox1.Text+"%' ", connection);

            DataSet can = new DataSet();

            adaptor.Fill(can, "xx");

            datagridkasa.DataSource = can.Tables[0];
            datagridkasa.Columns[0].Width = 30;
            datagridkasa.Columns[1].Width = 65;
            datagridkasa.Columns[2].Width = 45;
            datagridkasa.Columns[6].Width = 70;
            connection.Close();
        }
    }

    private void kullanıcıIslemleri_Click(object sender, EventArgs e)
    {
      adminBilgileri info=new adminBilgileri();
      info.Show();
    }

    private void yedekleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Backup();
    }
    private void Backup()
    {
      try
      {
        string path = "";
        FolderBrowserDialog f = new FolderBrowserDialog();
        string databaseName = connection.Database.ToString();//O an kullanılan db nin adını alıyoruz

        if (f.ShowDialog() == DialogResult.OK)
        {
          path = f.SelectedPath;
        }
        string query = "BACKUP DATABASE [" + databaseName + "] TO DISK='" + path + "\\Veritabanı - ["+DateTime.Now.Hour + "." + DateTime.Now.Minute +"-"+ DateTime.Now.ToLongDateString() + "].bak'";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
          if (connection.State != ConnectionState.Open)
          {
            connection.Open();
          }
          command.ExecuteNonQuery();
          connection.Close();
          MessageBox.Show("Veritabanı yedekleme işlemi başarılı!", "Bilgi"); 
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Hata Açıklaması:\n"+ex.Message);
      }  
    }
       
    private void geriYükleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      restoreDB();
      uyelerListele();
      projeListele();
      kadroListele();
      etkinlikListele();
      demirbasListele();
    }

    private void restoreDB()
    {
      if (connection.State!=ConnectionState.Open)
	    {
		    connection.Open();
	    }
      try
      {
        string path="";
        OpenFileDialog of = new OpenFileDialog();
        of.Filter="MS-SQL Files (*.bak)|*.bak|All Files|*.*";
        of.Title = "Geri yüklemek istediğiniz veritabanını seçiniz...";
        string databaseName=connection.Database.ToString();
        if (of.ShowDialog() == DialogResult.OK)
        {
          path=of.FileName;
          string sqlStmt2 = string.Format("ALTER DATABASE [" + databaseName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
          SqlCommand bu2 = new SqlCommand(sqlStmt2, connection);
          bu2.ExecuteNonQuery();

          string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + databaseName + "] FROM DISK='" + path + "'WITH REPLACE;";
          SqlCommand bu3 = new SqlCommand(sqlStmt3, connection);
          bu3.ExecuteNonQuery();

          string sqlStmt4 = string.Format("ALTER DATABASE [" + databaseName + "] SET MULTI_USER");
          SqlCommand bu4 = new SqlCommand(sqlStmt4, connection);
          bu4.ExecuteNonQuery();

          MessageBox.Show("Geri Yükleme Başarılı!", "Geri Yükleme Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

          connection.Close();   
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Geri Yüklemede Hata Oluştu!" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult yes = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if (DialogResult.Yes == yes)
      {
        Environment.Exit(0);

      }
      else { e.Cancel = true; }
    }

    private void datagriduyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void excelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab == tabPage1)
        {
          try
          {
            excelaktar(datagriduyeler);
            MessageBox.Show("Veriler excell'e aktarıldı.","Bilgi");
          }
          catch (Exception ex)
          {
            MessageBox.Show("Hata :\n"+ex.Message);
          }
          

        }

        if (tabControl1.SelectedTab == tabPage2)
        {
         try{
            excelaktar(datagirdkadro);
            MessageBox.Show("Veriler excell'e aktarıldı.", "Bilgi");
            }
             catch (Exception ex)
          {
            MessageBox.Show("Hata :\n"+ex.Message);
          }
        }

        if (tabControl1.SelectedTab == tabPage3)
        {
         try{
            excelaktar(datagirddemirbas);
            }
             catch (Exception ex)
          {
            MessageBox.Show("Hata :\n"+ex.Message);
          }

        }

        if (tabControl1.SelectedTab == tabPage4)
        {
        try{
            excelaktar(datagirdprojeler);
            }
             catch (Exception ex)
          {
            MessageBox.Show("Hata :\n"+ex.Message);
          }

        }

        if (tabControl1.SelectedTab == tabPage5)
        {
         try{
            excelaktar(datagirdetkinlikler);
            }
             catch (Exception ex)
          {
            MessageBox.Show("Hata :\n"+ex.Message);
          }

        }

        if (tabControl1.SelectedTab == tabPage6)
        {
        try{
            excelaktar(datagridkasa);
           }
             catch (Exception ex)
          {
            MessageBox.Show("Hata :\n"+ex.Message);
          }

        }
    }

    private void toolStripTextBox1_Click(object sender, EventArgs e)
    {
        toolStripTextBox1.Text = "";
    }

    private void toolStripTextBox1_Enter(object sender, EventArgs e)
    {
      if (toolStripTextBox1.Text == "Ara")
      {
        toolStripTextBox1.Text = "";
      }
    }

    private void toolStripTextBox1_Leave(object sender, EventArgs e)
    {
      if (toolStripTextBox1.Text == "")
      {
        toolStripTextBox1.Text = "Ara";
        toolStripTextBox1.ForeColor = Color.Gray;
      }
    }

    private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
    {
     
    }
  }
}