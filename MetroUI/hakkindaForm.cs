using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;

namespace MetroUI
{
  public partial class hakkindaForm : MetroForm
  {
    public hakkindaForm()
    {
      InitializeComponent();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
