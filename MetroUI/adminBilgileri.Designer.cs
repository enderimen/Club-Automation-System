namespace MetroUI
{
  partial class adminBilgileri
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminBilgileri));
      this.username = new System.Windows.Forms.TextBox();
      this.ipucu = new System.Windows.Forms.TextBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.pemailsifre = new System.Windows.Forms.TextBox();
      this.email = new System.Windows.Forms.TextBox();
      this.pMail = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // username
      // 
      this.username.Enabled = false;
      this.username.Location = new System.Drawing.Point(39, 96);
      this.username.Multiline = true;
      this.username.Name = "username";
      this.username.Size = new System.Drawing.Size(211, 31);
      this.username.TabIndex = 0;
      this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ipucu
      // 
      this.ipucu.Location = new System.Drawing.Point(39, 147);
      this.ipucu.Multiline = true;
      this.ipucu.Name = "ipucu";
      this.ipucu.Size = new System.Drawing.Size(211, 31);
      this.ipucu.TabIndex = 1;
      this.ipucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.toolTip1.SetToolTip(this.ipucu, "Bu alan şifre değiştirme işlemlerinde kullanılacaktır.Unutmayınız.");
      // 
      // toolTip1
      // 
      this.toolTip1.AutomaticDelay = 50;
      this.toolTip1.AutoPopDelay = 5000;
      this.toolTip1.InitialDelay = 50;
      this.toolTip1.IsBalloon = true;
      this.toolTip1.ReshowDelay = 10;
      this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.toolTip1.ToolTipTitle = "Önemli";
      // 
      // pemailsifre
      // 
      this.pemailsifre.Location = new System.Drawing.Point(39, 297);
      this.pemailsifre.Multiline = true;
      this.pemailsifre.Name = "pemailsifre";
      this.pemailsifre.Size = new System.Drawing.Size(211, 31);
      this.pemailsifre.TabIndex = 4;
      this.pemailsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.toolTip1.SetToolTip(this.pemailsifre, "Aktivasyon kodu göndermek için gereklidir.\r\nNot:Kulüp e-mail hesabı şifresidir.");
      // 
      // email
      // 
      this.email.Location = new System.Drawing.Point(39, 198);
      this.email.Multiline = true;
      this.email.Name = "email";
      this.email.Size = new System.Drawing.Size(211, 31);
      this.email.TabIndex = 2;
      this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.toolTip1.SetToolTip(this.email, "Bu alan şifrenizi unuttuğuz zaman programa giriş\r\nyapabilmeniz için gerekli olan " +
        "aktivasyon kodu için önemlidir.");
      // 
      // pMail
      // 
      this.pMail.Location = new System.Drawing.Point(39, 248);
      this.pMail.Multiline = true;
      this.pMail.Name = "pMail";
      this.pMail.Size = new System.Drawing.Size(211, 31);
      this.pMail.TabIndex = 3;
      this.pMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.toolTip1.SetToolTip(this.pMail, "Aktivasyon kodu göndermek için gereklidir.\r\nNot:Kulüp e-mail hesabıdır.");
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(37, 130);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "İpucu";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(38, 80);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Kullanıcı Adı";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button1.Location = new System.Drawing.Point(39, 336);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(211, 39);
      this.button1.TabIndex = 5;
      this.button1.Text = "Değişiklikleri Kaydet";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(38, 281);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(87, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "Kulüp Mail Şifresi";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(38, 183);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "Sizin Mail Hesabınız";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(38, 232);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(88, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Kulüp Mail Adresi";
      // 
      // adminBilgileri
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
      this.ClientSize = new System.Drawing.Size(296, 389);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.pMail);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.email);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.pemailsifre);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ipucu);
      this.Controls.Add(this.username);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "adminBilgileri";
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Admin İşlemleri";
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.Load += new System.EventHandler(this.adminBilgileri_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox username;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.TextBox ipucu;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox pemailsifre;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox email;
    private System.Windows.Forms.TextBox pMail;
    private System.Windows.Forms.Label label5;

  }
}