using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            versionlabel.Text = "v" + (FileVersionInfo.GetVersionInfo((Assembly.GetExecutingAssembly()).Location)).FileVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Form1.OpenBrowser("mailto:orphamiel@yahoo.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            Form1.OpenBrowser("https://www.microsoft.com/p/autoclicker-powered-by-weatherlightscom/9p929t9p1j1m");
        }
    }
}
