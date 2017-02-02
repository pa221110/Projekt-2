using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Mateusz Klucznik");
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url.Text);
        }

        private void Textbox1_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                webBrowser1.Navigate(url.Text);
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                ProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                ProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
    }

}
