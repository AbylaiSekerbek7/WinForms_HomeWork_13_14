using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_HomeWork_13_14
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog FBD = new FolderBrowserDialog() { Description = "Select Path to Open" })
      {
        if (FBD.ShowDialog() == DialogResult.OK)
        {
          webBrowser.Url = new Uri(FBD.SelectedPath);
          txtPath.Text = FBD.SelectedPath;
        }
      }
    }

    private void btnGoBack_Click(object sender, EventArgs e)
    {
      if (webBrowser.CanGoBack)
      {
        webBrowser.GoBack();
      }
    }

    private void btnGoForward_Click(object sender, EventArgs e)
    {
      if (webBrowser.CanGoForward)
      {
        webBrowser.GoForward();
      }
    }
  }
}
