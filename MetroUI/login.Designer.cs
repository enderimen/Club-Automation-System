namespace MetroUI
{
  partial class login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.username = new System.Windows.Forms.TextBox();
      this.userpassword = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(18, 11);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(55, 55);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 4;
      this.pictureBox2.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.SlateGray;
      this.label1.Location = new System.Drawing.Point(81, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Şifremi Unuttum";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.pictureBox2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 364);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(366, 82);
      this.panel2.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(128, 21);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(111, 111);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // username
      // 
      this.username.Enabled = false;
      this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.username.ForeColor = System.Drawing.Color.SlateGray;
      this.username.Location = new System.Drawing.Point(58, 38);
      this.username.Multiline = true;
      this.username.Name = "username";
      this.username.Size = new System.Drawing.Size(246, 35);
      this.username.TabIndex = 0;
      this.username.Text = "Admin";
      this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.username.WordWrap = false;
      // 
      // userpassword
      // 
      this.userpassword.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userpassword.ForeColor = System.Drawing.Color.SlateGray;
      this.userpassword.Location = new System.Drawing.Point(58, 95);
      this.userpassword.Multiline = true;
      this.userpassword.Name = "userpassword";
      this.userpassword.PasswordChar = '⚫';
      this.userpassword.Size = new System.Drawing.Size(246, 36);
      this.userpassword.TabIndex = 0;
      this.userpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.userpassword.WordWrap = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button1.Location = new System.Drawing.Point(58, 150);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(246, 39);
      this.button1.TabIndex = 1;
      this.button1.Text = "Giriş Yap";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.userpassword);
      this.panel1.Controls.Add(this.username);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 138);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(366, 226);
      this.panel1.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.label3.Location = new System.Drawing.Point(57, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Şifre";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.label2.Location = new System.Drawing.Point(57, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Kullanıcı Adı";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.BackColor = System.Drawing.Color.White;
      this.checkBox1.Location = new System.Drawing.Point(287, 105);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(15, 14);
      this.checkBox1.TabIndex = 3;
      this.checkBox1.UseVisualStyleBackColor = false;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // login
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(366, 446);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "login";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.White;
      this.Text = "LOGİN";
      this.Load += new System.EventHandler(this.login_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox userpassword;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox username;

  }
}