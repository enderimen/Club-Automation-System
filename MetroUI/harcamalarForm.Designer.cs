namespace MetroUI
{
  partial class harcamalarForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(harcamalarForm));
      this.btnEtkinlikKaydet = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
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
      this.btnEtkinlikKaydet.Location = new System.Drawing.Point(195, 317);
      this.btnEtkinlikKaydet.Name = "btnEtkinlikKaydet";
      this.btnEtkinlikKaydet.Size = new System.Drawing.Size(77, 37);
      this.btnEtkinlikKaydet.TabIndex = 2;
      this.btnEtkinlikKaydet.Text = "Kaydet";
      this.btnEtkinlikKaydet.UseVisualStyleBackColor = false;
      this.btnEtkinlikKaydet.Click += new System.EventHandler(this.btnEtkinlikKaydet_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.dateTimePicker1);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBox5);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 52);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(260, 248);
      this.groupBox1.TabIndex = 24;
      this.groupBox1.TabStop = false;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(109, 75);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(111, 20);
      this.textBox3.TabIndex = 36;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 78);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 35;
      this.label4.Text = "*Alınan :";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(109, 208);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
      this.dateTimePicker1.TabIndex = 33;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(16, 214);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(34, 13);
      this.label7.TabIndex = 34;
      this.label7.Text = "Tarih:";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(109, 180);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(111, 20);
      this.textBox2.TabIndex = 32;
      this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 183);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 31;
      this.label3.Text = "*Yetkili :";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(109, 114);
      this.textBox5.Multiline = true;
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(134, 44);
      this.textBox5.TabIndex = 21;
      this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(109, 30);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(111, 20);
      this.textBox1.TabIndex = 20;
      this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 117);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 23;
      this.label2.Text = "Açıklama:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "*Harcanan Para:";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.ImageKey = "save.png";
      this.button1.Location = new System.Drawing.Point(112, 317);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(77, 37);
      this.button1.TabIndex = 25;
      this.button1.Text = "Güncelle";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // harcamalarForm
      // 
      this.AcceptButton = this.btnEtkinlikKaydet;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
      this.ClientSize = new System.Drawing.Size(284, 377);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnEtkinlikKaydet);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "harcamalarForm";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Harcamalar";
      this.Load += new System.EventHandler(this.harcamalarForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEtkinlikKaydet;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label4;
  }
}