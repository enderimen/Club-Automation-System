namespace MetroUI
{
  partial class paraEkleForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paraEkleForm));
      this.btnEtkinlikKaydet = new System.Windows.Forms.Button();
      this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
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
      this.btnEtkinlikKaydet.Location = new System.Drawing.Point(192, 237);
      this.btnEtkinlikKaydet.Name = "btnEtkinlikKaydet";
      this.btnEtkinlikKaydet.Size = new System.Drawing.Size(76, 37);
      this.btnEtkinlikKaydet.TabIndex = 23;
      this.btnEtkinlikKaydet.Text = "Kaydet";
      this.btnEtkinlikKaydet.UseVisualStyleBackColor = false;
      this.btnEtkinlikKaydet.Click += new System.EventHandler(this.btnEtkinlikKaydet_Click);
      // 
      // ımageList1
      // 
      this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
      this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dateTimePicker1);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.textBox5);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(8, 55);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(260, 173);
      this.groupBox1.TabIndex = 27;
      this.groupBox1.TabStop = false;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(94, 134);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
      this.dateTimePicker1.TabIndex = 29;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(47, 141);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(34, 13);
      this.label7.TabIndex = 30;
      this.label7.Text = "Tarih:";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(94, 49);
      this.textBox5.Multiline = true;
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(148, 50);
      this.textBox5.TabIndex = 28;
      this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(94, 106);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(111, 20);
      this.textBox2.TabIndex = 27;
      this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(94, 23);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(111, 20);
      this.textBox1.TabIndex = 26;
      this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 109);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 25;
      this.label3.Text = "*Teslim Alan:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 24;
      this.label2.Text = "*Açıklama:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 13);
      this.label1.TabIndex = 23;
      this.label1.Text = "*Alınan Para:";
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
      this.button1.Location = new System.Drawing.Point(110, 237);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(76, 37);
      this.button1.TabIndex = 28;
      this.button1.Text = "Güncelle";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // paraEkleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 292);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnEtkinlikKaydet);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "paraEkleForm";
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Para Ekle";
      this.Load += new System.EventHandler(this.paraEkleForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEtkinlikKaydet;
    private System.Windows.Forms.ImageList ımageList1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label7;
  }
}