using CustomScraper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScraperExample
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private ScrapeClient client;

        public ScrapeClient Client
        {
            get
            {
                return client;
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            var but = (Button)sender;
            but.Enabled = false;
            Task.Run(() =>
            {
                ScrapeClient tempClient = null;
                if (ScrapeClient.TryCreateInstance(txtUsername.Text, txtPassword.Text, ref tempClient))
                {
                    but.Invoke(new Action(() =>
                    {
                        this.client = tempClient;
                        this.Close();
                    }));
                }
                else
                {
                    but.Invoke(new Action(() =>
                    {
                        but.Enabled = true;
                        MessageBox.Show("Login failed.");
                        txtPassword.Text = "";
                    }));
                }
            });
        }
    }
}
