﻿namespace MetroUI
{
  partial class demirbaslarForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demirbaslarForm));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
      this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
      this.btnDemirbasGuncelle = new System.Windows.Forms.Button();
      this.btnDemirbasKaydet = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.numericUpDown1);
      this.groupBox1.Controls.Add(this.dateTimePicker1);
      this.groupBox1.Controls.Add(this.textBox4);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(9, 73);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(330, 264);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Demirbaş Bilgileri";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(103, 86);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
      this.numericUpDown1.TabIndex = 2;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(103, 162);
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(21, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 166);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "Alınan Yıl:";
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
      this.label4.Size = new System.Drawing.Size(30, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Cins:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "*Adet:";
      // 
      // ımageList1
      // 
      this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
      this.ımageList1.Tag = "";
      this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList1.Images.SetKeyName(0, "edit.png");
      // 
      // ımageList2
      // 
      this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
      this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
      this.ımageList2.Images.SetKeyName(0, "save.png");
      // 
      // btnDemirbasGuncelle
      // 
      this.btnDemirbasGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.btnDemirbasGuncelle.FlatAppearance.BorderSize = 0;
      this.btnDemirbasGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDemirbasGuncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.btnDemirbasGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnDemirbasGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDemirbasGuncelle.ImageKey = "edit.png";
      this.btnDemirbasGuncelle.ImageList = this.ımageList1;
      this.btnDemirbasGuncelle.Location = new System.Drawing.Point(90, 349);
      this.btnDemirbasGuncelle.Name = "btnDemirbasGuncelle";
      this.btnDemirbasGuncelle.Size = new System.Drawing.Size(127, 37);
      this.btnDemirbasGuncelle.TabIndex = 1;
      this.btnDemirbasGuncelle.Text = "         Güncelle";
      this.btnDemirbasGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDemirbasGuncelle.UseVisualStyleBackColor = false;
      this.btnDemirbasGuncelle.Click += new System.EventHandler(this.btnDemirbasGuncelle_Click_1);
      // 
      // btnDemirbasKaydet
      // 
      this.btnDemirbasKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.btnDemirbasKaydet.FlatAppearance.BorderSize = 0;
      this.btnDemirbasKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDemirbasKaydet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.btnDemirbasKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.btnDemirbasKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDemirbasKaydet.ImageKey = "save.png";
      this.btnDemirbasKaydet.ImageList = this.ımageList2;
      this.btnDemirbasKaydet.Location = new System.Drawing.Point(223, 349);
      this.btnDemirbasKaydet.Name = "btnDemirbasKaydet";
      this.btnDemirbasKaydet.Size = new System.Drawing.Size(116, 37);
      this.btnDemirbasKaydet.TabIndex = 0;
      this.btnDemirbasKaydet.Text = "          Kaydet";
      this.btnDemirbasKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDemirbasKaydet.UseVisualStyleBackColor = false;
      this.btnDemirbasKaydet.Click += new System.EventHandler(this.btnDemirbasKaydet_Click_1);
      // 
      // demirbaslarForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(348, 418);
      this.Controls.Add(this.btnDemirbasGuncelle);
      this.Controls.Add(this.btnDemirbasKaydet);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "demirbaslarForm";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Demirbaşlar";
      this.Load += new System.EventHandler(this.Demirbaşlar_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ImageList ımageList1;
    private System.Windows.Forms.ImageList ımageList2;
    private System.Windows.Forms.Button btnDemirbasGuncelle;
    private System.Windows.Forms.Button btnDemirbasKaydet;
  }
}