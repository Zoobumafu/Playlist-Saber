﻿
namespace BeatSaber_Playlist_Master_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playlistTreeView = new System.Windows.Forms.TreeView();
            this.newPlaylistButton = new System.Windows.Forms.Button();
            this.songsInPlaylistTreeView = new System.Windows.Forms.TreeView();
            this.allSongsTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playlistDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.playlistPictureBox = new System.Windows.Forms.PictureBox();
            this.playlistNameTextBox = new System.Windows.Forms.TextBox();
            this.playlistAuthorTextBox = new System.Windows.Forms.TextBox();
            this.playlistDeleteButton = new System.Windows.Forms.Button();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.songAuthorLabel = new System.Windows.Forms.Label();
            this.songPictureBox = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastModifiedLabel = new System.Windows.Forms.Label();
            this.addResultsButton = new System.Windows.Forms.Button();
            this.unplaylistedCheckbox = new System.Windows.Forms.CheckBox();
            this.hashLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumOfSongsLabel = new System.Windows.Forms.Label();
            this.clearPlaylistButton = new System.Windows.Forms.Button();
            this.openSongFolderButton = new System.Windows.Forms.Button();
            this.removeDuplicatesButton = new System.Windows.Forms.Button();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.moreInfoButton = new System.Windows.Forms.Button();
            this.runInDesktopButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.noArrowsModeButton = new System.Windows.Forms.Button();
            this.oneSaberModeButton = new System.Windows.Forms.Button();
            this.ninetyDegreeModeButton = new System.Windows.Forms.Button();
            this.threeSixyModeButton = new System.Windows.Forms.Button();
            this.lightShowModeButton = new System.Windows.Forms.Button();
            this.changeInstallLocation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.downloadSongButton = new System.Windows.Forms.Button();
            this.downloadingSongLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.openSongFinderButton = new System.Windows.Forms.Button();
            this.downloadAllMissingSongsButton = new System.Windows.Forms.Button();
            this.playlistExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistTreeView
            // 
            this.playlistTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playlistTreeView.HideSelection = false;
            this.playlistTreeView.LabelEdit = true;
            this.playlistTreeView.Location = new System.Drawing.Point(14, 227);
            this.playlistTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistTreeView.Name = "playlistTreeView";
            this.playlistTreeView.ShowLines = false;
            this.playlistTreeView.ShowPlusMinus = false;
            this.playlistTreeView.ShowRootLines = false;
            this.playlistTreeView.Size = new System.Drawing.Size(361, 212);
            this.playlistTreeView.TabIndex = 1;
            this.playlistTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.playlistTreeView_AfterLabelEdit);
            this.playlistTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.playlistTreeView_AfterSelect);
            // 
            // newPlaylistButton
            // 
            this.newPlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.newPlaylistButton.FlatAppearance.BorderSize = 0;
            this.newPlaylistButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.newPlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPlaylistButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.New_Playlist;
            this.newPlaylistButton.Location = new System.Drawing.Point(14, 168);
            this.newPlaylistButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPlaylistButton.Name = "newPlaylistButton";
            this.newPlaylistButton.Size = new System.Drawing.Size(186, 51);
            this.newPlaylistButton.TabIndex = 2;
            this.newPlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newPlaylistButton.UseVisualStyleBackColor = false;
            this.newPlaylistButton.Click += new System.EventHandler(this.newPlaylistButton_Click);
            // 
            // songsInPlaylistTreeView
            // 
            this.songsInPlaylistTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.songsInPlaylistTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songsInPlaylistTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.songsInPlaylistTreeView.ForeColor = System.Drawing.Color.White;
            this.songsInPlaylistTreeView.HideSelection = false;
            this.songsInPlaylistTreeView.Location = new System.Drawing.Point(14, 665);
            this.songsInPlaylistTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.songsInPlaylistTreeView.Name = "songsInPlaylistTreeView";
            this.songsInPlaylistTreeView.ShowLines = false;
            this.songsInPlaylistTreeView.ShowPlusMinus = false;
            this.songsInPlaylistTreeView.ShowRootLines = false;
            this.songsInPlaylistTreeView.Size = new System.Drawing.Size(567, 508);
            this.songsInPlaylistTreeView.TabIndex = 3;
            this.songsInPlaylistTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.songsInPlaylistTreeView_DrawNode);
            this.songsInPlaylistTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.songsInPlaylistTreeView_AfterSelect);
            this.songsInPlaylistTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songsInPlaylistTreeView_MouseDoubleClick);
            // 
            // allSongsTreeView
            // 
            this.allSongsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.allSongsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allSongsTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allSongsTreeView.ForeColor = System.Drawing.Color.White;
            this.allSongsTreeView.HideSelection = false;
            this.allSongsTreeView.Location = new System.Drawing.Point(608, 279);
            this.allSongsTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allSongsTreeView.Name = "allSongsTreeView";
            this.allSongsTreeView.ShowLines = false;
            this.allSongsTreeView.ShowPlusMinus = false;
            this.allSongsTreeView.ShowRootLines = false;
            this.allSongsTreeView.Size = new System.Drawing.Size(528, 629);
            this.allSongsTreeView.TabIndex = 0;
            this.allSongsTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.allSongsTreeView_DrawNode);
            this.allSongsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.allSongsTreeView_AfterSelect);
            this.allSongsTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allSongsTreeView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(14, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(14, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(14, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // playlistDescriptionTextBox
            // 
            this.playlistDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.playlistDescriptionTextBox.Location = new System.Drawing.Point(14, 539);
            this.playlistDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistDescriptionTextBox.Name = "playlistDescriptionTextBox";
            this.playlistDescriptionTextBox.ReadOnly = true;
            this.playlistDescriptionTextBox.Size = new System.Drawing.Size(567, 67);
            this.playlistDescriptionTextBox.TabIndex = 9;
            this.playlistDescriptionTextBox.Text = "";
            this.playlistDescriptionTextBox.TextChanged += new System.EventHandler(this.playlistDescriptionTextBox_TextChanged);
            // 
            // playlistPictureBox
            // 
            this.playlistPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistPictureBox.Enabled = false;
            this.playlistPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playlistPictureBox.Image")));
            this.playlistPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("playlistPictureBox.InitialImage")));
            this.playlistPictureBox.Location = new System.Drawing.Point(382, 227);
            this.playlistPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistPictureBox.Name = "playlistPictureBox";
            this.playlistPictureBox.Size = new System.Drawing.Size(199, 212);
            this.playlistPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playlistPictureBox.TabIndex = 10;
            this.playlistPictureBox.TabStop = false;
            this.playlistPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // playlistNameTextBox
            // 
            this.playlistNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistNameTextBox.Enabled = false;
            this.playlistNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.playlistNameTextBox.Location = new System.Drawing.Point(96, 447);
            this.playlistNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistNameTextBox.Name = "playlistNameTextBox";
            this.playlistNameTextBox.Size = new System.Drawing.Size(485, 20);
            this.playlistNameTextBox.TabIndex = 11;
            this.playlistNameTextBox.TextChanged += new System.EventHandler(this.playlistNameTextBox_TextChanged);
            // 
            // playlistAuthorTextBox
            // 
            this.playlistAuthorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistAuthorTextBox.Enabled = false;
            this.playlistAuthorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.playlistAuthorTextBox.Location = new System.Drawing.Point(96, 480);
            this.playlistAuthorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistAuthorTextBox.Name = "playlistAuthorTextBox";
            this.playlistAuthorTextBox.Size = new System.Drawing.Size(485, 20);
            this.playlistAuthorTextBox.TabIndex = 12;
            this.playlistAuthorTextBox.TextChanged += new System.EventHandler(this.playlistAuthorTextBox_TextChanged);
            // 
            // playlistDeleteButton
            // 
            this.playlistDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.playlistDeleteButton.FlatAppearance.BorderSize = 0;
            this.playlistDeleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.playlistDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playlistDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playlistDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistDeleteButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Remove_Playlists;
            this.playlistDeleteButton.Location = new System.Drawing.Point(207, 168);
            this.playlistDeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistDeleteButton.Name = "playlistDeleteButton";
            this.playlistDeleteButton.Size = new System.Drawing.Size(181, 51);
            this.playlistDeleteButton.TabIndex = 13;
            this.playlistDeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playlistDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playlistDeleteButton.UseVisualStyleBackColor = false;
            this.playlistDeleteButton.Click += new System.EventHandler(this.playlistDeleteButton_Click);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.ForeColor = System.Drawing.Color.Linen;
            this.songNameLabel.Location = new System.Drawing.Point(694, 945);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(0, 20);
            this.songNameLabel.TabIndex = 14;
            // 
            // songAuthorLabel
            // 
            this.songAuthorLabel.AutoSize = true;
            this.songAuthorLabel.ForeColor = System.Drawing.Color.Linen;
            this.songAuthorLabel.Location = new System.Drawing.Point(694, 975);
            this.songAuthorLabel.Name = "songAuthorLabel";
            this.songAuthorLabel.Size = new System.Drawing.Size(0, 20);
            this.songAuthorLabel.TabIndex = 15;
            // 
            // songPictureBox
            // 
            this.songPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("songPictureBox.Image")));
            this.songPictureBox.Location = new System.Drawing.Point(965, 1023);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(171, 200);
            this.songPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPictureBox.TabIndex = 16;
            this.songPictureBox.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.Location = new System.Drawing.Point(665, 240);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(161, 27);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(926, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sort By - ";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.ForeColor = System.Drawing.Color.Linen;
            this.lastModifiedLabel.Location = new System.Drawing.Point(693, 1007);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(0, 20);
            this.lastModifiedLabel.TabIndex = 20;
            // 
            // addResultsButton
            // 
            this.addResultsButton.BackColor = System.Drawing.Color.Transparent;
            this.addResultsButton.FlatAppearance.BorderSize = 0;
            this.addResultsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addResultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addResultsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResultsButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addResultsButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Add_songs;
            this.addResultsButton.Location = new System.Drawing.Point(921, 112);
            this.addResultsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addResultsButton.Name = "addResultsButton";
            this.addResultsButton.Size = new System.Drawing.Size(210, 64);
            this.addResultsButton.TabIndex = 21;
            this.addResultsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addResultsButton.UseVisualStyleBackColor = false;
            this.addResultsButton.Click += new System.EventHandler(this.addResultsButton_Click);
            // 
            // unplaylistedCheckbox
            // 
            this.unplaylistedCheckbox.AutoSize = true;
            this.unplaylistedCheckbox.ForeColor = System.Drawing.Color.Linen;
            this.unplaylistedCheckbox.Location = new System.Drawing.Point(607, 916);
            this.unplaylistedCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unplaylistedCheckbox.Name = "unplaylistedCheckbox";
            this.unplaylistedCheckbox.Size = new System.Drawing.Size(301, 24);
            this.unplaylistedCheckbox.TabIndex = 22;
            this.unplaylistedCheckbox.Text = "Only show songs that are not in a playlist";
            this.unplaylistedCheckbox.UseVisualStyleBackColor = true;
            this.unplaylistedCheckbox.CheckedChanged += new System.EventHandler(this.unplaylistedCheckbox_CheckedChanged);
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(454, 1193);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(140, 20);
            this.hashLabel.TabIndex = 23;
            this.hashLabel.Text = "Invisible Hash Label";
            this.hashLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(1021, 917);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Song Count - ";
            // 
            // NumOfSongsLabel
            // 
            this.NumOfSongsLabel.AutoSize = true;
            this.NumOfSongsLabel.ForeColor = System.Drawing.Color.Linen;
            this.NumOfSongsLabel.Location = new System.Drawing.Point(1105, 917);
            this.NumOfSongsLabel.Name = "NumOfSongsLabel";
            this.NumOfSongsLabel.Size = new System.Drawing.Size(0, 20);
            this.NumOfSongsLabel.TabIndex = 25;
            // 
            // clearPlaylistButton
            // 
            this.clearPlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.clearPlaylistButton.FlatAppearance.BorderSize = 0;
            this.clearPlaylistButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clearPlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPlaylistButton.ForeColor = System.Drawing.Color.LightCoral;
            this.clearPlaylistButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Clean_Playlist;
            this.clearPlaylistButton.Location = new System.Drawing.Point(14, 1179);
            this.clearPlaylistButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearPlaylistButton.Name = "clearPlaylistButton";
            this.clearPlaylistButton.Size = new System.Drawing.Size(195, 51);
            this.clearPlaylistButton.TabIndex = 26;
            this.clearPlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearPlaylistButton.UseVisualStyleBackColor = false;
            this.clearPlaylistButton.Click += new System.EventHandler(this.clearPlaylistButton_Click);
            // 
            // openSongFolderButton
            // 
            this.openSongFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.openSongFolderButton.FlatAppearance.BorderSize = 0;
            this.openSongFolderButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.openSongFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openSongFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openSongFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSongFolderButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.openSongFolderButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Open_Song_Folder;
            this.openSongFolderButton.Location = new System.Drawing.Point(598, 1084);
            this.openSongFolderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openSongFolderButton.Name = "openSongFolderButton";
            this.openSongFolderButton.Size = new System.Drawing.Size(190, 55);
            this.openSongFolderButton.TabIndex = 27;
            this.openSongFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openSongFolderButton.UseVisualStyleBackColor = false;
            this.openSongFolderButton.Click += new System.EventHandler(this.openSongFolderButton_Click);
            // 
            // removeDuplicatesButton
            // 
            this.removeDuplicatesButton.BackColor = System.Drawing.Color.Transparent;
            this.removeDuplicatesButton.FlatAppearance.BorderSize = 0;
            this.removeDuplicatesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.removeDuplicatesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.removeDuplicatesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeDuplicatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDuplicatesButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.removeDuplicatesButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Remove_Duplicates;
            this.removeDuplicatesButton.Location = new System.Drawing.Point(216, 1180);
            this.removeDuplicatesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeDuplicatesButton.Name = "removeDuplicatesButton";
            this.removeDuplicatesButton.Size = new System.Drawing.Size(203, 51);
            this.removeDuplicatesButton.TabIndex = 28;
            this.removeDuplicatesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeDuplicatesButton.UseVisualStyleBackColor = false;
            this.removeDuplicatesButton.Click += new System.EventHandler(this.removeDuplicatesButton_Click);
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.ForeColor = System.Drawing.Color.Linen;
            this.dateRadioButton.Location = new System.Drawing.Point(5, 4);
            this.dateRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(62, 24);
            this.dateRadioButton.TabIndex = 0;
            this.dateRadioButton.Text = "Date";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            this.dateRadioButton.CheckedChanged += new System.EventHandler(this.dateRadioButton_CheckedChanged);
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.ForeColor = System.Drawing.Color.Linen;
            this.nameRadioButton.Location = new System.Drawing.Point(67, 4);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(70, 24);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            this.nameRadioButton.CheckedChanged += new System.EventHandler(this.nameRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameRadioButton);
            this.panel1.Controls.Add(this.dateRadioButton);
            this.panel1.Location = new System.Drawing.Point(999, 237);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 33);
            this.panel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(608, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(607, 945);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Song name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Linen;
            this.label8.Location = new System.Drawing.Point(607, 975);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Map maker:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(14, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 42);
            this.label9.TabIndex = 35;
            this.label9.Text = "Songs in this playlist -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(608, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 42);
            this.label10.TabIndex = 36;
            this.label10.Text = "All songs - ";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.saveButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Save_Changes;
            this.saveButton.Location = new System.Drawing.Point(947, 57);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 64);
            this.saveButton.TabIndex = 4;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moreInfoButton
            // 
            this.moreInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.moreInfoButton.FlatAppearance.BorderSize = 0;
            this.moreInfoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.moreInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.moreInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.moreInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreInfoButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.moreInfoButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.More_Info;
            this.moreInfoButton.Location = new System.Drawing.Point(598, 1031);
            this.moreInfoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moreInfoButton.Name = "moreInfoButton";
            this.moreInfoButton.Size = new System.Drawing.Size(136, 59);
            this.moreInfoButton.TabIndex = 40;
            this.moreInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.moreInfoButton.UseVisualStyleBackColor = false;
            this.moreInfoButton.Click += new System.EventHandler(this.moreInfoButton_Click);
            // 
            // runInDesktopButton
            // 
            this.runInDesktopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.runInDesktopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runInDesktopButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.runInDesktopButton.Image = ((System.Drawing.Image)(resources.GetObject("runInDesktopButton.Image")));
            this.runInDesktopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runInDesktopButton.Location = new System.Drawing.Point(451, 47);
            this.runInDesktopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.runInDesktopButton.Name = "runInDesktopButton";
            this.runInDesktopButton.Size = new System.Drawing.Size(235, 36);
            this.runInDesktopButton.TabIndex = 41;
            this.runInDesktopButton.Text = "Run BeatSaber in desktop mode";
            this.runInDesktopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.runInDesktopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.runInDesktopButton.UseVisualStyleBackColor = true;
            this.runInDesktopButton.Visible = false;
            this.runInDesktopButton.Click += new System.EventHandler(this.runInDesktopButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Linen;
            this.label11.Location = new System.Drawing.Point(606, 1007);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Added:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Exit;
            this.exitButton.Location = new System.Drawing.Point(1091, 11);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 52);
            this.exitButton.TabIndex = 43;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // noArrowsModeButton
            // 
            this.noArrowsModeButton.BackColor = System.Drawing.Color.Transparent;
            this.noArrowsModeButton.FlatAppearance.BorderSize = 0;
            this.noArrowsModeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.noArrowsModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.noArrowsModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noArrowsModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noArrowsModeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.noArrowsModeButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.No_Arrows_Unclicked;
            this.noArrowsModeButton.Location = new System.Drawing.Point(606, 189);
            this.noArrowsModeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noArrowsModeButton.Name = "noArrowsModeButton";
            this.noArrowsModeButton.Size = new System.Drawing.Size(127, 40);
            this.noArrowsModeButton.TabIndex = 45;
            this.noArrowsModeButton.UseVisualStyleBackColor = false;
            this.noArrowsModeButton.Click += new System.EventHandler(this.noArrowsModeButton_Click);
            // 
            // oneSaberModeButton
            // 
            this.oneSaberModeButton.BackColor = System.Drawing.Color.Transparent;
            this.oneSaberModeButton.FlatAppearance.BorderSize = 0;
            this.oneSaberModeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.oneSaberModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.oneSaberModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.oneSaberModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneSaberModeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.oneSaberModeButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.One_Saber_Unclicked;
            this.oneSaberModeButton.Location = new System.Drawing.Point(739, 189);
            this.oneSaberModeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oneSaberModeButton.Name = "oneSaberModeButton";
            this.oneSaberModeButton.Size = new System.Drawing.Size(127, 40);
            this.oneSaberModeButton.TabIndex = 46;
            this.oneSaberModeButton.UseVisualStyleBackColor = false;
            this.oneSaberModeButton.Click += new System.EventHandler(this.oneSaberModeButton_Click);
            // 
            // ninetyDegreeModeButton
            // 
            this.ninetyDegreeModeButton.BackColor = System.Drawing.Color.Transparent;
            this.ninetyDegreeModeButton.FlatAppearance.BorderSize = 0;
            this.ninetyDegreeModeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ninetyDegreeModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ninetyDegreeModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ninetyDegreeModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ninetyDegreeModeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ninetyDegreeModeButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.nintyDegreesUnclicked1;
            this.ninetyDegreeModeButton.Location = new System.Drawing.Point(873, 189);
            this.ninetyDegreeModeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ninetyDegreeModeButton.Name = "ninetyDegreeModeButton";
            this.ninetyDegreeModeButton.Size = new System.Drawing.Size(127, 40);
            this.ninetyDegreeModeButton.TabIndex = 47;
            this.ninetyDegreeModeButton.UseVisualStyleBackColor = false;
            this.ninetyDegreeModeButton.Click += new System.EventHandler(this.ninetyDegreeModeButton_Click);
            // 
            // threeSixyModeButton
            // 
            this.threeSixyModeButton.BackColor = System.Drawing.Color.Transparent;
            this.threeSixyModeButton.FlatAppearance.BorderSize = 0;
            this.threeSixyModeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.threeSixyModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.threeSixyModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.threeSixyModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeSixyModeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.threeSixyModeButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.threeSixtyUnclicked;
            this.threeSixyModeButton.Location = new System.Drawing.Point(1007, 189);
            this.threeSixyModeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.threeSixyModeButton.Name = "threeSixyModeButton";
            this.threeSixyModeButton.Size = new System.Drawing.Size(128, 40);
            this.threeSixyModeButton.TabIndex = 48;
            this.threeSixyModeButton.UseVisualStyleBackColor = false;
            this.threeSixyModeButton.Click += new System.EventHandler(this.threeSixyModeButton_Click);
            // 
            // lightShowModeButton
            // 
            this.lightShowModeButton.BackColor = System.Drawing.Color.Transparent;
            this.lightShowModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lightShowModeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lightShowModeButton.Location = new System.Drawing.Point(433, 65);
            this.lightShowModeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lightShowModeButton.Name = "lightShowModeButton";
            this.lightShowModeButton.Size = new System.Drawing.Size(102, 40);
            this.lightShowModeButton.TabIndex = 49;
            this.lightShowModeButton.UseVisualStyleBackColor = false;
            this.lightShowModeButton.Visible = false;
            this.lightShowModeButton.Click += new System.EventHandler(this.lightShowModeButton_Click);
            // 
            // changeInstallLocation
            // 
            this.changeInstallLocation.BackColor = System.Drawing.Color.Transparent;
            this.changeInstallLocation.FlatAppearance.BorderSize = 0;
            this.changeInstallLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeInstallLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeInstallLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeInstallLocation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.changeInstallLocation.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Open_Song_Folder_1;
            this.changeInstallLocation.Location = new System.Drawing.Point(433, 11);
            this.changeInstallLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeInstallLocation.Name = "changeInstallLocation";
            this.changeInstallLocation.Size = new System.Drawing.Size(265, 67);
            this.changeInstallLocation.TabIndex = 50;
            this.changeInstallLocation.UseVisualStyleBackColor = false;
            this.changeInstallLocation.Click += new System.EventHandler(this.changeInstallLocation_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(608, 1193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 23);
            this.label12.TabIndex = 51;
            this.label12.Text = "V0.2.1";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabelGithub.Location = new System.Drawing.Point(665, 1193);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(89, 20);
            this.linkLabelGithub.TabIndex = 53;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github Page";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // downloadSongButton
            // 
            this.downloadSongButton.Location = new System.Drawing.Point(607, 1143);
            this.downloadSongButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downloadSongButton.Name = "downloadSongButton";
            this.downloadSongButton.Size = new System.Drawing.Size(120, 31);
            this.downloadSongButton.TabIndex = 54;
            this.downloadSongButton.Text = "Download Song";
            this.downloadSongButton.UseVisualStyleBackColor = true;
            this.downloadSongButton.Visible = false;
            this.downloadSongButton.Click += new System.EventHandler(this.downloadSongButton_Click);
            // 
            // downloadingSongLabel
            // 
            this.downloadingSongLabel.AutoSize = true;
            this.downloadingSongLabel.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadingSongLabel.Location = new System.Drawing.Point(607, 1143);
            this.downloadingSongLabel.Name = "downloadingSongLabel";
            this.downloadingSongLabel.Size = new System.Drawing.Size(143, 24);
            this.downloadingSongLabel.TabIndex = 55;
            this.downloadingSongLabel.Text = "Downloading song...";
            this.downloadingSongLabel.Visible = false;
            // 
            // previewButton
            // 
            this.previewButton.BackColor = System.Drawing.Color.Transparent;
            this.previewButton.FlatAppearance.BorderSize = 0;
            this.previewButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.previewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.previewButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.Preview;
            this.previewButton.Location = new System.Drawing.Point(1008, 960);
            this.previewButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(133, 56);
            this.previewButton.TabIndex = 56;
            this.previewButton.UseVisualStyleBackColor = false;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // openSongFinderButton
            // 
            this.openSongFinderButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.threeSixtyClicked;
            this.openSongFinderButton.Location = new System.Drawing.Point(433, 129);
            this.openSongFinderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openSongFinderButton.Name = "openSongFinderButton";
            this.openSongFinderButton.Size = new System.Drawing.Size(159, 31);
            this.openSongFinderButton.TabIndex = 57;
            this.openSongFinderButton.Text = "Open Song Finder";
            this.openSongFinderButton.UseVisualStyleBackColor = true;
            this.openSongFinderButton.Visible = false;
            this.openSongFinderButton.Click += new System.EventHandler(this.openSongFinderButton_Click);
            // 
            // downloadAllMissingSongsButton
            // 
            this.downloadAllMissingSongsButton.Location = new System.Drawing.Point(433, 91);
            this.downloadAllMissingSongsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downloadAllMissingSongsButton.Name = "downloadAllMissingSongsButton";
            this.downloadAllMissingSongsButton.Size = new System.Drawing.Size(193, 31);
            this.downloadAllMissingSongsButton.TabIndex = 58;
            this.downloadAllMissingSongsButton.Text = "Download All Missing Songs";
            this.downloadAllMissingSongsButton.UseVisualStyleBackColor = true;
            this.downloadAllMissingSongsButton.Visible = false;
            this.downloadAllMissingSongsButton.Click += new System.EventHandler(this.downloadAllMissingSongsButton_Click);
            // 
            // playlistExportButton
            // 
            this.playlistExportButton.Location = new System.Drawing.Point(758, 37);
            this.playlistExportButton.Name = "playlistExportButton";
            this.playlistExportButton.Size = new System.Drawing.Size(150, 29);
            this.playlistExportButton.TabIndex = 59;
            this.playlistExportButton.Text = "Export Playlist";
            this.playlistExportButton.UseVisualStyleBackColor = true;
            this.playlistExportButton.Click += new System.EventHandler(this.playlistExportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1150, 1055);
            this.Controls.Add(this.playlistExportButton);
            this.Controls.Add(this.downloadAllMissingSongsButton);
            this.Controls.Add(this.openSongFinderButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.downloadingSongLabel);
            this.Controls.Add(this.downloadSongButton);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.changeInstallLocation);
            this.Controls.Add(this.lightShowModeButton);
            this.Controls.Add(this.threeSixyModeButton);
            this.Controls.Add(this.ninetyDegreeModeButton);
            this.Controls.Add(this.oneSaberModeButton);
            this.Controls.Add(this.noArrowsModeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.runInDesktopButton);
            this.Controls.Add(this.moreInfoButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeDuplicatesButton);
            this.Controls.Add(this.openSongFolderButton);
            this.Controls.Add(this.clearPlaylistButton);
            this.Controls.Add(this.NumOfSongsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.unplaylistedCheckbox);
            this.Controls.Add(this.addResultsButton);
            this.Controls.Add(this.lastModifiedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.songPictureBox);
            this.Controls.Add(this.songAuthorLabel);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.playlistDeleteButton);
            this.Controls.Add(this.playlistAuthorTextBox);
            this.Controls.Add(this.playlistNameTextBox);
            this.Controls.Add(this.playlistPictureBox);
            this.Controls.Add(this.playlistDescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.songsInPlaylistTreeView);
            this.Controls.Add(this.newPlaylistButton);
            this.Controls.Add(this.playlistTreeView);
            this.Controls.Add(this.allSongsTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist Saber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newPlaylistButton;
        private System.Windows.Forms.TreeView songsInPlaylistTreeView;
        private System.Windows.Forms.TreeView allSongsTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox playlistDescriptionTextBox;
        private System.Windows.Forms.PictureBox playlistPictureBox;
        private System.Windows.Forms.TextBox playlistNameTextBox;
        private System.Windows.Forms.TextBox playlistAuthorTextBox;
        private System.Windows.Forms.Button playlistDeleteButton;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Label songAuthorLabel;
        private System.Windows.Forms.PictureBox songPictureBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastModifiedLabel;
        private System.Windows.Forms.Button addResultsButton;
        private System.Windows.Forms.CheckBox unplaylistedCheckbox;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumOfSongsLabel;
        private System.Windows.Forms.Button clearPlaylistButton;
        private System.Windows.Forms.Button openSongFolderButton;
        private System.Windows.Forms.Button removeDuplicatesButton;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button moreInfoButton;
        private System.Windows.Forms.Button runInDesktopButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button noArrowsModeButton;
        private System.Windows.Forms.Button oneSaberModeButton;
        private System.Windows.Forms.Button ninetyDegreeModeButton;
        private System.Windows.Forms.Button threeSixyModeButton;
        private System.Windows.Forms.Button lightShowModeButton;
        private System.Windows.Forms.Button changeInstallLocation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Button downloadSongButton;
        private System.Windows.Forms.Label downloadingSongLabel;
        private System.Windows.Forms.Button previewButton;
        public System.Windows.Forms.TreeView playlistTreeView;
        private System.Windows.Forms.Button openSongFinderButton;
        private System.Windows.Forms.Button downloadAllMissingSongsButton;
        private System.Windows.Forms.Button playlistExportButton;
    }
}

