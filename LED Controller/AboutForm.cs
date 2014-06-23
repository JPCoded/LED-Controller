using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Controller
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblApplication.Text = System.Windows.Forms.Application.ProductName;
            lblVersion.Text = String.Format("v.{0}", System.Windows.Forms.Application.ProductVersion);
            lblAuthor.Text = "John Pomeroy\nJPCoded@gmail.com";
            lnkGit.Text = "https://github.com/JPCoded/LED-Controller";
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JPCoded/LED-Controller");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
