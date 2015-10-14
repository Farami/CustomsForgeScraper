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
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.Official = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Downloads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lead = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rhythm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vocals = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DynamicDifficulty = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Xbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Playstation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.txtSearch.Location = new System.Drawing.Point(74, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(994, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.Location = new System.Drawing.Point(154, 89);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(914, 23);
            this.butSearch.TabIndex = 2;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(16, 89);
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
            this.Official,
            this.Artist,
            this.Song,
            this.Album,
            this.Tuning,
            this.Author,
            this.Version,
            this.CreateDate,
            this.Updated,
            this.Downloads,
            this.Lead,
            this.Rhythm,
            this.Bass,
            this.Vocals,
            this.DynamicDifficulty,
            this.PC,
            this.Mac,
            this.Xbox,
            this.Playstation,
            this.Download});
            this.dataSearchResults.Location = new System.Drawing.Point(16, 118);
            this.dataSearchResults.Name = "dataSearchResults";
            this.dataSearchResults.Size = new System.Drawing.Size(1052, 302);
            this.dataSearchResults.TabIndex = 4;
            this.dataSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearchResults_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter artist";
            // 
            // txtArtist
            // 
            this.txtArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtist.Location = new System.Drawing.Point(74, 36);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(994, 20);
            this.txtArtist.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter song";
            // 
            // txtSong
            // 
            this.txtSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSong.Location = new System.Drawing.Point(74, 63);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(994, 20);
            this.txtSong.TabIndex = 8;
            // 
            // Official
            // 
            this.Official.HeaderText = "Official";
            this.Official.Name = "Official";
            this.Official.ReadOnly = true;
            this.Official.Width = 45;
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
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Width = 61;
            // 
            // Tuning
            // 
            this.Tuning.HeaderText = "Tuning";
            this.Tuning.Name = "Tuning";
            this.Tuning.ReadOnly = true;
            this.Tuning.Width = 65;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 63;
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Width = 67;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "Created";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 69;
            // 
            // Updated
            // 
            this.Updated.HeaderText = "Updated";
            this.Updated.Name = "Updated";
            this.Updated.ReadOnly = true;
            this.Updated.Width = 73;
            // 
            // Downloads
            // 
            this.Downloads.HeaderText = "Downloads";
            this.Downloads.Name = "Downloads";
            this.Downloads.ReadOnly = true;
            this.Downloads.Width = 85;
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
            // DynamicDifficulty
            // 
            this.DynamicDifficulty.HeaderText = "DD";
            this.DynamicDifficulty.Name = "DynamicDifficulty";
            this.DynamicDifficulty.ReadOnly = true;
            this.DynamicDifficulty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DynamicDifficulty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DynamicDifficulty.Width = 48;
            // 
            // PC
            // 
            this.PC.HeaderText = "PC";
            this.PC.Name = "PC";
            this.PC.ReadOnly = true;
            this.PC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PC.Width = 46;
            // 
            // Mac
            // 
            this.Mac.HeaderText = "Mac";
            this.Mac.Name = "Mac";
            this.Mac.ReadOnly = true;
            this.Mac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Mac.Width = 53;
            // 
            // Xbox
            // 
            this.Xbox.HeaderText = "Xbox";
            this.Xbox.Name = "Xbox";
            this.Xbox.ReadOnly = true;
            this.Xbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xbox.Width = 56;
            // 
            // Playstation
            // 
            this.Playstation.HeaderText = "PS3";
            this.Playstation.Name = "Playstation";
            this.Playstation.ReadOnly = true;
            this.Playstation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Playstation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Playstation.Width = 52;
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
            this.ClientSize = new System.Drawing.Size(1080, 432);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Official;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Downloads;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lead;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rhythm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vocals;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DynamicDifficulty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Xbox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Playstation;
        private System.Windows.Forms.DataGridViewLinkColumn Download;
    }
}