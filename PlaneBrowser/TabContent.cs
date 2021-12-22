using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace PlaneBrowser
{
    public partial class TabContent : Form
    {
        public TabContent()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Back();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Forward();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Reload();
        }

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textBox1.Text=e.Address.ToString();
            });
        }
    }
}
