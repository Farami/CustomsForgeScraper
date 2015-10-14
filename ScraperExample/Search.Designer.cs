namespace ScraperExample
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.dataSearchResults = new System.Windows.Forms.DataGridView();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Official = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lead = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rhythm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vocals = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(60, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(829, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.Location = new System.Drawing.Point(154, 36);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(735, 23);
            this.butSearch.TabIndex = 2;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(16, 36);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(118, 23);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // dataSearchResults
            // 
            this.dataSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.Song,
            this.Tuning,
            this.Official,
            this.Lead,
            this.Rhythm,
            this.Bass,
            this.Vocals,
            this.Download});
            this.dataSearchResults.Location = new System.Drawing.Point(16, 65);
            this.dataSearchResults.Name = "dataSearchResults";
            this.dataSearchResults.Size = new System.Drawing.Size(873, 332);
            this.dataSearchResults.TabIndex = 4;
            this.dataSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearchResults_CellClick);
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Width = 55;
            // 
            // Song
            // 
            this.Song.HeaderText = "Song";
            this.Song.Name = "Song";
            this.Song.ReadOnly = true;
            this.Song.Width = 57;
            // 
            // Tuning
            // 
            this.Tuning.HeaderText = "Tuning";
            this.Tuning.Name = "Tuning";
            this.Tuning.ReadOnly = true;
            this.Tuning.Width = 65;
            // 
            // Official
            // 
            this.Official.HeaderText = "Official";
            this.Official.Name = "Official";
            this.Official.ReadOnly = true;
            this.Official.Width = 45;
            // 
            // Lead
            // 
            this.Lead.HeaderText = "Lead";
            this.Lead.Name = "Lead";
            this.Lead.ReadOnly = true;
            this.Lead.Width = 37;
            // 
            // Rhythm
            // 
            this.Rhythm.HeaderText = "Rhythm";
            this.Rhythm.Name = "Rhythm";
            this.Rhythm.ReadOnly = true;
            this.Rhythm.Width = 49;
            // 
            // Bass
            // 
            this.Bass.HeaderText = "Bass";
            this.Bass.Name = "Bass";
            this.Bass.ReadOnly = true;
            this.Bass.Width = 36;
            // 
            // Vocals
            // 
            this.Vocals.HeaderText = "Vocals";
            this.Vocals.Name = "Vocals";
            this.Vocals.ReadOnly = true;
            this.Vocals.Width = 45;
            // 
            // Download
            // 
            this.Download.HeaderText = "Download";
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            this.Download.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Download.Width = 61;
            // 
            // Search
            // 
            this.AcceptButton = this.butSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 409);
            this.Controls.Add(this.dataSearchResults);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "CustomsForge Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.DataGridView dataSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Official;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lead;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rhythm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vocals;
        private System.Windows.Forms.DataGridViewLinkColumn Download;
    }
}