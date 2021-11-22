namespace BeatSaber_Playlist_Master_V2
{
    partial class songFinder
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
            this.playlistTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSongSearch = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSongSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistTreeView
            // 
            this.playlistTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playlistTreeView.HideSelection = false;
            this.playlistTreeView.Location = new System.Drawing.Point(12, 33);
            this.playlistTreeView.Name = "playlistTreeView";
            this.playlistTreeView.ShowLines = false;
            this.playlistTreeView.ShowPlusMinus = false;
            this.playlistTreeView.ShowRootLines = false;
            this.playlistTreeView.Size = new System.Drawing.Size(251, 162);
            this.playlistTreeView.TabIndex = 2;
            this.playlistTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.playlistTreeView_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a playlist to add the songs to:";
            // 
            // dataGridSongSearch
            // 
            this.dataGridSongSearch.AllowUserToAddRows = false;
            this.dataGridSongSearch.AllowUserToDeleteRows = false;
            this.dataGridSongSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.dataGridSongSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSongSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Name,
            this.Author,
            this.Length,
            this.Rating,
            this.Difficulties,
            this.Uploaded,
            this.Download});
            this.dataGridSongSearch.Location = new System.Drawing.Point(12, 201);
            this.dataGridSongSearch.Name = "dataGridSongSearch";
            this.dataGridSongSearch.ReadOnly = true;
            this.dataGridSongSearch.RowHeadersVisible = false;
            this.dataGridSongSearch.RowTemplate.Height = 25;
            this.dataGridSongSearch.Size = new System.Drawing.Size(979, 424);
            this.dataGridSongSearch.TabIndex = 5;
            this.dataGridSongSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSongSearch_CellClick);
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // Difficulties
            // 
            this.Difficulties.HeaderText = "Difficulties";
            this.Difficulties.Name = "Difficulties";
            this.Difficulties.ReadOnly = true;
            // 
            // Uploaded
            // 
            this.Uploaded.HeaderText = "Uploaded";
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.ReadOnly = true;
            // 
            // Download
            // 
            this.Download.HeaderText = "Download";
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(916, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // songFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1003, 637);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridSongSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playlistTreeView);
            //this.Name = "songFinder";
            this.Text = "songFinder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSongSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView playlistTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridSongSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploaded;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
    }
}