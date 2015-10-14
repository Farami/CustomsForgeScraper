using CustomScraper;
using CustomScraper.Model;
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
    public partial class Search : Form
    {
        private ScrapeClient client;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            if(client == null)
            {
                DoLogin();
            }
        }

        private void DoLogin()
        {
            var login = new Login();
            DialogResult res = login.ShowDialog(this);
            this.client = login.Client;
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if(client == null)
            {
                DoLogin();
            }

            AddResults(DoLookup(txtSearch.Text));
        }

        private List<Song> DoLookup(string term)
        {
            var res = client.Lookup(term);
            if(res.Error)
            {
                return null;
            }
            else
            {
                return res.Results;
            }
        }

        private void AddResults(List<Song> songs)
        {
            dataSearchResults.Rows.Clear();
            foreach(var song in songs)
            {
                dataSearchResults.Rows.Add(song.Artist, song.Title, song.Tuning, song.Official, song.Lead, song.Rhythm, song.Bass, song.Vocals, song.GetDownloadLink());
            }
        }

        private void dataSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8)
            {
                var url = (string)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                System.Diagnostics.Process.Start(url);
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            dataSearchResults.Rows.Clear();
            txtSearch.Text = "";
        }
    }
}
