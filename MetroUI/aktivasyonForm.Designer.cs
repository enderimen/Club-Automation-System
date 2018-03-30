namespace MetroUI
{
  partial class aktivasyonForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.aktivasyon = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.txtipucu = new System.Windows.Forms.TextBox();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
      this.button1.Location = new System.Drawing.Point(29, 194);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(220, 49);
      this.button1.TabIndex = 5;
      this.button1.Text = "Doğrula";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.label1.Location = new System.Drawing.Point(25, 88);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(224, 40);
      this.label1.TabIndex = 3;
      this.label1.Text = "Kayıtlı mail adresine aktivasyon\r\nkodu gönderildi.";
      // 
      // aktivasyon
      // 
      this.aktivasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.27F);
      this.aktivasyon.Location = new System.Drawing.Point(29, 146);
      this.aktivasyon.Multiline = true;
      this.aktivasyon.Name = "aktivasyon";
      this.aktivasyon.Size = new System.Drawing.Size(220, 30);
      this.aktivasyon.TabIndex = 4;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button2);
      this.panel2.Controls.Add(this.txtipucu);
      this.panel2.Location = new System.Drawing.Point(29, 88);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(220, 155);
      this.panel2.TabIndex = 7;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.White;
      this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
      this.button2.Location = new System.Drawing.Point(16, 84);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(188, 49);
      this.button2.TabIndex = 1;
      this.button2.Text = "İpucunu Doğrula";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // txtipucu
      // 
      this.txtipucu.Location = new System.Drawing.Point(16, 34);
      this.txtipucu.Multiline = true;
      this.txtipucu.Name = "txtipucu";
      this.txtipucu.Size = new System.Drawing.Size(188, 34);
      this.txtipucu.TabIndex = 0;
      this.txtipucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // aktivasyonForm
      // 
      this.AcceptButton = this.button2;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
      this.ClientSize = new System.Drawing.Size(277, 283);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.aktivasyon);
      this.MaximizeBox = false;
      this.Name = "aktivasyonForm";
      this.Resizable = false;
      this.Style = MetroFramework.MetroColorStyle.Orange;
      this.Text = "Şifremi Unuttum";
      this.Theme = MetroFramework.MetroThemeStyle.Dark;
      this.Load += new System.EventHandler(this.aktivasyonForm_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox aktivasyon;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtipucu;
  }
}