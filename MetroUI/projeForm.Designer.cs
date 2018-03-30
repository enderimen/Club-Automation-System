namespace MetroUI
{
  partial class projeForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projeForm));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label10 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnProjeGuncelle = new System.Windows.Forms.Button();
      this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
      this.btnProjeKaydet = new System.Windows.Forms.Button();
      this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "*Proje Adı:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "*Konusu :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 120);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Açıklama:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 161);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "Yıl:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Controls.Add(this.textBox5);
      this.groupBox1.Controls.Add(this.textBox6);
      this.groupBox1.Controls.Add(this.textBox7);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.dateTimePicker1);
      this.groupBox1.Controls.Add(this.textBox4);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(9, 26);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(330, 330);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Proje Bilgileri";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(6, 200);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(80, 13);
      this.label10.TabIndex = 35;
      this.label10.Text = "PROJE SAHİBİ";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Hazırlık",
            "1.Sınıf",
            "2.Sınıf",
            "3.Sınıf",
            "4.Sınıf"});
      this.comboBox1.Location = new System.Drawing.Point(103, 273);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(100, 21);
      this.comboBox1.TabIndex = 7;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(103, 302);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(100, 20);
      this.textBox5.TabIndex = 8;
      this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(103, 248);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(100, 20);
      this.textBox6.TabIndex = 6;
      this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
      // 
      // textBox7
      // 
      this.textBox7.Location = new System.Drawing.Point(103, 220);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(100, 20);
      this.textBox7.TabIndex = 5;
      this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 301);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 13);
      this.label6.TabIndex = 30;
      this.label6.Text = "*Okul No:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(16, 271);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(36, 13);
      this.label7.TabIndex = 31;
      this.label7.Text = "*Sınıfı:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(16, 247);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(46, 13);
      this.label8.TabIndex = 32;
      this.label8.Text = "*Soyadı:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(16, 223);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(29, 13);
      this.label9.TabIndex = 33;
      this.label9.Text = "*Adı:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(103, 161);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
      this.dateTimePicker1.TabIndex = 4;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(103, 111);
      this.textBox4.Multiline = true;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(207, 44);
      this.textBox4.TabIndex = 3;
      this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(103, 85);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 2;
      this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(103, 57);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 1;
      this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
      // 
      // textBox1
      // 
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(103, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 0;
      // 
      // btnProjeGuncelle
      // 
      this.btnProjeGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.btnProjeGuncelle.FlatAppearance.BorderSize = 0;
      this.btnProjeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnProjeGuncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.btnProjeGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnProjeGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnProjeGuncelle.ImageKey = "edit.png";
      this.btnProjeGuncelle.ImageList = this.ımageList2;
      this.btnProjeGuncelle.Location = new System.Drawing.Point(83, 362);
      this.btnProjeGuncelle.Name = "btnProjeGuncelle";
      this.btnProjeGuncelle.Size = new System.Drawing.Size(127, 37);
      this.btnProjeGuncelle.TabIndex = 1;
      this.btnProjeGuncelle.Text = "         Güncelle";
      this.btnProjeGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnProjeGuncelle.UseVisualStyleBackColor = false;
      this.btnProjeGuncelle.Click += new System.EventHandler(this.btnProjeGuncelle_Click);
      // 
      // ımageList2
      // 
      this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
      this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList2.Images.SetKeyName(0, "edit.png");
      // 
      // btnProjeKaydet
      // 
      this.btnProjeKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.btnProjeKaydet.FlatAppearance.BorderSize = 0;
      this.btnProjeKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnProjeKaydet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.btnProjeKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnProjeKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnProjeKaydet.ImageKey = "save.png";
      this.btnProjeKaydet.ImageList = this.ımageList1;
      this.btnProjeKaydet.Location = new System.Drawing.Point(223, 362);
      this.btnProjeKaydet.Name = "btnProjeKaydet";
      this.btnProjeKaydet.Size = new System.Drawing.Size(116, 37);
      this.btnProjeKaydet.TabIndex = 0;
      this.btnProjeKaydet.Text = "          Kaydet";
      this.btnProjeKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnProjeKaydet.UseVisualStyleBackColor = false;
      this.btnProjeKaydet.Click += new System.EventHandler(this.btnProjeKaydet_Click);
      // 
      // ımageList1
      // 
      this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
      this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList1.Images.SetKeyName(0, "save.png");
      // 
      // projeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
      this.ClientSize = new System.Drawing.Size(348, 418);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnProjeKaydet);
      this.Controls.Add(this.btnProjeGuncelle);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "projeForm";
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Projeler";
      this.Load += new System.EventHandler(this.demirbaslar_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnProjeGuncelle;
    private System.Windows.Forms.ImageList ımageList2;
    private System.Windows.Forms.Button btnProjeKaydet;
    private System.Windows.Forms.ImageList ımageList1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
  }
}