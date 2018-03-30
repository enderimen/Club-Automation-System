namespace MetroUI
{
  partial class etkinlikForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etkinlikForm));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.txtKonusmacilar = new System.Windows.Forms.TextBox();
      this.txtYer = new System.Windows.Forms.TextBox();
      this.txtKonu = new System.Windows.Forms.TextBox();
      this.txtAdi = new System.Windows.Forms.TextBox();
      this.txtID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnEtkinlikGuncelle = new System.Windows.Forms.Button();
      this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnEtkinlikKaydet = new System.Windows.Forms.Button();
      this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dateTimePicker1);
      this.groupBox1.Controls.Add(this.txtKonusmacilar);
      this.groupBox1.Controls.Add(this.txtYer);
      this.groupBox1.Controls.Add(this.txtKonu);
      this.groupBox1.Controls.Add(this.txtAdi);
      this.groupBox1.Controls.Add(this.txtID);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(9, 73);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(330, 271);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Etkinlik Bilgileri";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(103, 207);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
      this.dateTimePicker1.TabIndex = 5;
      // 
      // txtKonusmacilar
      // 
      this.txtKonusmacilar.Location = new System.Drawing.Point(103, 120);
      this.txtKonusmacilar.Multiline = true;
      this.txtKonusmacilar.Name = "txtKonusmacilar";
      this.txtKonusmacilar.Size = new System.Drawing.Size(207, 44);
      this.txtKonusmacilar.TabIndex = 3;
      this.txtKonusmacilar.Leave += new System.EventHandler(this.txtKonusmacilar_Leave);
      // 
      // txtYer
      // 
      this.txtYer.Location = new System.Drawing.Point(103, 170);
      this.txtYer.Name = "txtYer";
      this.txtYer.Size = new System.Drawing.Size(100, 20);
      this.txtYer.TabIndex = 4;
      this.txtYer.Leave += new System.EventHandler(this.txtYer_Leave);
      // 
      // txtKonu
      // 
      this.txtKonu.Location = new System.Drawing.Point(103, 88);
      this.txtKonu.Name = "txtKonu";
      this.txtKonu.Size = new System.Drawing.Size(100, 20);
      this.txtKonu.TabIndex = 2;
      this.txtKonu.Leave += new System.EventHandler(this.txtKonu_Leave);
      // 
      // txtAdi
      // 
      this.txtAdi.Location = new System.Drawing.Point(103, 57);
      this.txtAdi.Name = "txtAdi";
      this.txtAdi.Size = new System.Drawing.Size(100, 20);
      this.txtAdi.TabIndex = 1;
      this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
      this.txtAdi.Leave += new System.EventHandler(this.txtAdi_Leave);
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(103, 25);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(100, 20);
      this.txtID.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(21, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 211);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(34, 13);
      this.label6.TabIndex = 1;
      this.label6.Text = "Tarih:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 177);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "*Yer:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "*Adı:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 120);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Konuşmacılar:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "*Konu:";
      // 
      // btnEtkinlikGuncelle
      // 
      this.btnEtkinlikGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.btnEtkinlikGuncelle.FlatAppearance.BorderSize = 0;
      this.btnEtkinlikGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEtkinlikGuncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.btnEtkinlikGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnEtkinlikGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEtkinlikGuncelle.ImageKey = "edit.png";
      this.btnEtkinlikGuncelle.ImageList = this.ımageList1;
      this.btnEtkinlikGuncelle.Location = new System.Drawing.Point(90, 356);
      this.btnEtkinlikGuncelle.Name = "btnEtkinlikGuncelle";
      this.btnEtkinlikGuncelle.Size = new System.Drawing.Size(127, 37);
      this.btnEtkinlikGuncelle.TabIndex = 1;
      this.btnEtkinlikGuncelle.Text = "         Güncelle";
      this.btnEtkinlikGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEtkinlikGuncelle.UseVisualStyleBackColor = false;
      this.btnEtkinlikGuncelle.Click += new System.EventHandler(this.btnEtkinlikGuncelle_Click);
      // 
      // ımageList1
      // 
      this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
      this.ımageList1.Tag = "";
      this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList1.Images.SetKeyName(0, "edit.png");
      // 
      // btnEtkinlikKaydet
      // 
      this.btnEtkinlikKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.btnEtkinlikKaydet.FlatAppearance.BorderSize = 0;
      this.btnEtkinlikKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEtkinlikKaydet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.btnEtkinlikKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnEtkinlikKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEtkinlikKaydet.ImageKey = "save.png";
      this.btnEtkinlikKaydet.ImageList = this.ımageList2;
      this.btnEtkinlikKaydet.Location = new System.Drawing.Point(223, 356);
      this.btnEtkinlikKaydet.Name = "btnEtkinlikKaydet";
      this.btnEtkinlikKaydet.Size = new System.Drawing.Size(116, 37);
      this.btnEtkinlikKaydet.TabIndex = 0;
      this.btnEtkinlikKaydet.Text = "          Kaydet";
      this.btnEtkinlikKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEtkinlikKaydet.UseVisualStyleBackColor = false;
      this.btnEtkinlikKaydet.Click += new System.EventHandler(this.btnEtkinlikKaydet_Click);
      // 
      // ımageList2
      // 
      this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
      this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList2.Images.SetKeyName(0, "save.png");
      // 
      // etkinlikForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(348, 418);
      this.Controls.Add(this.btnEtkinlikGuncelle);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnEtkinlikKaydet);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "etkinlikForm";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Etkinlikler";
      this.Load += new System.EventHandler(this.etkinlikForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnEtkinlikGuncelle;
    private System.Windows.Forms.ImageList ımageList1;
    private System.Windows.Forms.Button btnEtkinlikKaydet;
    private System.Windows.Forms.ImageList ımageList2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox txtKonusmacilar;
    private System.Windows.Forms.TextBox txtAdi;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtYer;
    private System.Windows.Forms.TextBox txtKonu;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.Label label1;
  }
}