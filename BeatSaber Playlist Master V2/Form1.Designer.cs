
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
            this.playlistTreeView.Location = new System.Drawing.Point(12, 155);
            this.playlistTreeView.Name = "playlistTreeView";
            this.playlistTreeView.ShowLines = false;
            this.playlistTreeView.ShowPlusMinus = false;
            this.playlistTreeView.ShowRootLines = false;
            this.playlistTreeView.Size = new System.Drawing.Size(316, 174);
            this.playlistTreeView.TabIndex = 1;
            this.playlistTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.playlistTreeView_AfterLabelEdit);
            this.playlistTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.playlistTreeView_AfterSelect);
            // 
            // newPlaylistButton
            // 
            this.newPlaylistButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.newPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newPlaylistButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.pngfind1;
            this.newPlaylistButton.Location = new System.Drawing.Point(12, 126);
            this.newPlaylistButton.Name = "newPlaylistButton";
            this.newPlaylistButton.Size = new System.Drawing.Size(245, 23);
            this.newPlaylistButton.TabIndex = 2;
            this.newPlaylistButton.Text = "New Playlist";
            this.newPlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newPlaylistButton.UseVisualStyleBackColor = false;
            this.newPlaylistButton.Click += new System.EventHandler(this.newPlaylistButton_Click);
            // 
            // songsInPlaylistTreeView
            // 
            this.songsInPlaylistTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.songsInPlaylistTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songsInPlaylistTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.songsInPlaylistTreeView.HideSelection = false;
            this.songsInPlaylistTreeView.Location = new System.Drawing.Point(12, 499);
            this.songsInPlaylistTreeView.Name = "songsInPlaylistTreeView";
            this.songsInPlaylistTreeView.ShowLines = false;
            this.songsInPlaylistTreeView.ShowPlusMinus = false;
            this.songsInPlaylistTreeView.ShowRootLines = false;
            this.songsInPlaylistTreeView.Size = new System.Drawing.Size(496, 386);
            this.songsInPlaylistTreeView.TabIndex = 3;
            this.songsInPlaylistTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.songsInPlaylistTreeView_DrawNode);
            this.songsInPlaylistTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.songsInPlaylistTreeView_AfterSelect);
            this.songsInPlaylistTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songsInPlaylistTreeView_MouseDoubleClick);
            // 
            // allSongsTreeView
            // 
            this.allSongsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.allSongsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allSongsTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.allSongsTreeView.HideSelection = false;
            this.allSongsTreeView.Location = new System.Drawing.Point(532, 137);
            this.allSongsTreeView.Name = "allSongsTreeView";
            this.allSongsTreeView.ShowLines = false;
            this.allSongsTreeView.ShowPlusMinus = false;
            this.allSongsTreeView.ShowRootLines = false;
            this.allSongsTreeView.Size = new System.Drawing.Size(462, 566);
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
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(12, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(12, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // playlistDescriptionTextBox
            // 
            this.playlistDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.playlistDescriptionTextBox.Location = new System.Drawing.Point(12, 404);
            this.playlistDescriptionTextBox.Name = "playlistDescriptionTextBox";
            this.playlistDescriptionTextBox.ReadOnly = true;
            this.playlistDescriptionTextBox.Size = new System.Drawing.Size(496, 50);
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
            this.playlistPictureBox.Location = new System.Drawing.Point(334, 155);
            this.playlistPictureBox.Name = "playlistPictureBox";
            this.playlistPictureBox.Size = new System.Drawing.Size(174, 174);
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
            this.playlistNameTextBox.Location = new System.Drawing.Point(84, 335);
            this.playlistNameTextBox.Name = "playlistNameTextBox";
            this.playlistNameTextBox.Size = new System.Drawing.Size(424, 16);
            this.playlistNameTextBox.TabIndex = 11;
            this.playlistNameTextBox.TextChanged += new System.EventHandler(this.playlistNameTextBox_TextChanged);
            // 
            // playlistAuthorTextBox
            // 
            this.playlistAuthorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistAuthorTextBox.Enabled = false;
            this.playlistAuthorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.playlistAuthorTextBox.Location = new System.Drawing.Point(84, 360);
            this.playlistAuthorTextBox.Name = "playlistAuthorTextBox";
            this.playlistAuthorTextBox.Size = new System.Drawing.Size(424, 16);
            this.playlistAuthorTextBox.TabIndex = 12;
            this.playlistAuthorTextBox.TextChanged += new System.EventHandler(this.playlistAuthorTextBox_TextChanged);
            // 
            // playlistDeleteButton
            // 
            this.playlistDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playlistDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.playlistDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.playlistDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playlistDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("playlistDeleteButton.Image")));
            this.playlistDeleteButton.Location = new System.Drawing.Point(266, 126);
            this.playlistDeleteButton.Name = "playlistDeleteButton";
            this.playlistDeleteButton.Size = new System.Drawing.Size(245, 23);
            this.playlistDeleteButton.TabIndex = 13;
            this.playlistDeleteButton.Text = "Delete Playlist";
            this.playlistDeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playlistDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playlistDeleteButton.UseVisualStyleBackColor = false;
            this.playlistDeleteButton.Click += new System.EventHandler(this.playlistDeleteButton_Click);
            this.playlistDeleteButton.MouseLeave += new System.EventHandler(this.playlistDeleteButton_MouseLeave);
            this.playlistDeleteButton.MouseHover += new System.EventHandler(this.playlistDeleteButton_MouseHover);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.ForeColor = System.Drawing.Color.Linen;
            this.songNameLabel.Location = new System.Drawing.Point(608, 735);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(0, 15);
            this.songNameLabel.TabIndex = 14;
            // 
            // songAuthorLabel
            // 
            this.songAuthorLabel.AutoSize = true;
            this.songAuthorLabel.ForeColor = System.Drawing.Color.Linen;
            this.songAuthorLabel.Location = new System.Drawing.Point(608, 757);
            this.songAuthorLabel.Name = "songAuthorLabel";
            this.songAuthorLabel.Size = new System.Drawing.Size(0, 15);
            this.songAuthorLabel.TabIndex = 15;
            // 
            // songPictureBox
            // 
            this.songPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("songPictureBox.Image")));
            this.songPictureBox.Location = new System.Drawing.Point(844, 767);
            this.songPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(150, 150);
            this.songPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPictureBox.TabIndex = 16;
            this.songPictureBox.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.Location = new System.Drawing.Point(582, 108);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(141, 23);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(810, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sort By - ";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.ForeColor = System.Drawing.Color.Linen;
            this.lastModifiedLabel.Location = new System.Drawing.Point(608, 781);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(0, 15);
            this.lastModifiedLabel.TabIndex = 20;
            // 
            // addResultsButton
            // 
            this.addResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addResultsButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addResultsButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.eba3aeb057bd0a5401d2dcd3ba6271a91;
            this.addResultsButton.Location = new System.Drawing.Point(844, 709);
            this.addResultsButton.Name = "addResultsButton";
            this.addResultsButton.Size = new System.Drawing.Size(150, 23);
            this.addResultsButton.TabIndex = 21;
            this.addResultsButton.Text = "Add Results to Playlist";
            this.addResultsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addResultsButton.UseVisualStyleBackColor = true;
            this.addResultsButton.Click += new System.EventHandler(this.addResultsButton_Click);
            // 
            // unplaylistedCheckbox
            // 
            this.unplaylistedCheckbox.AutoSize = true;
            this.unplaylistedCheckbox.ForeColor = System.Drawing.Color.Linen;
            this.unplaylistedCheckbox.Location = new System.Drawing.Point(532, 713);
            this.unplaylistedCheckbox.Name = "unplaylistedCheckbox";
            this.unplaylistedCheckbox.Size = new System.Drawing.Size(242, 19);
            this.unplaylistedCheckbox.TabIndex = 22;
            this.unplaylistedCheckbox.Text = "Only show songs that are not in a playlist";
            this.unplaylistedCheckbox.UseVisualStyleBackColor = true;
            this.unplaylistedCheckbox.CheckedChanged += new System.EventHandler(this.unplaylistedCheckbox_CheckedChanged);
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(320, 895);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(111, 15);
            this.hashLabel.TabIndex = 23;
            this.hashLabel.Text = "Invisible Hash Label";
            this.hashLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(863, 735);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Song Count - ";
            // 
            // NumOfSongsLabel
            // 
            this.NumOfSongsLabel.AutoSize = true;
            this.NumOfSongsLabel.ForeColor = System.Drawing.Color.Linen;
            this.NumOfSongsLabel.Location = new System.Drawing.Point(937, 735);
            this.NumOfSongsLabel.Name = "NumOfSongsLabel";
            this.NumOfSongsLabel.Size = new System.Drawing.Size(0, 15);
            this.NumOfSongsLabel.TabIndex = 25;
            // 
            // clearPlaylistButton
            // 
            this.clearPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearPlaylistButton.ForeColor = System.Drawing.Color.LightCoral;
            this.clearPlaylistButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.clipart2195449;
            this.clearPlaylistButton.Location = new System.Drawing.Point(12, 891);
            this.clearPlaylistButton.Name = "clearPlaylistButton";
            this.clearPlaylistButton.Size = new System.Drawing.Size(148, 23);
            this.clearPlaylistButton.TabIndex = 26;
            this.clearPlaylistButton.Text = "Clear Playlist";
            this.clearPlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearPlaylistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearPlaylistButton.UseVisualStyleBackColor = true;
            this.clearPlaylistButton.Click += new System.EventHandler(this.clearPlaylistButton_Click);
            // 
            // openSongFolderButton
            // 
            this.openSongFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openSongFolderButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.openSongFolderButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.toppng_com_folder_icon_png_transparent_black_and_white_folder_ico_1589x1366;
            this.openSongFolderButton.Location = new System.Drawing.Point(532, 887);
            this.openSongFolderButton.Name = "openSongFolderButton";
            this.openSongFolderButton.Size = new System.Drawing.Size(126, 23);
            this.openSongFolderButton.TabIndex = 27;
            this.openSongFolderButton.Text = "Open Song Folder";
            this.openSongFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openSongFolderButton.UseVisualStyleBackColor = true;
            this.openSongFolderButton.Click += new System.EventHandler(this.openSongFolderButton_Click);
            // 
            // removeDuplicatesButton
            // 
            this.removeDuplicatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeDuplicatesButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.removeDuplicatesButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.PngItem_16805482;
            this.removeDuplicatesButton.Location = new System.Drawing.Point(166, 891);
            this.removeDuplicatesButton.Name = "removeDuplicatesButton";
            this.removeDuplicatesButton.Size = new System.Drawing.Size(148, 23);
            this.removeDuplicatesButton.TabIndex = 28;
            this.removeDuplicatesButton.Text = "Remove Duplicates";
            this.removeDuplicatesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeDuplicatesButton.UseVisualStyleBackColor = true;
            this.removeDuplicatesButton.Click += new System.EventHandler(this.removeDuplicatesButton_Click);
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.ForeColor = System.Drawing.Color.Linen;
            this.dateRadioButton.Location = new System.Drawing.Point(4, 3);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(49, 19);
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
            this.nameRadioButton.Location = new System.Drawing.Point(59, 3);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(57, 19);
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
            this.panel1.Location = new System.Drawing.Point(874, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 25);
            this.panel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(531, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(532, 735);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Song name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Linen;
            this.label8.Location = new System.Drawing.Point(532, 757);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Map maker:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(12, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 33);
            this.label9.TabIndex = 35;
            this.label9.Text = "Songs in this playlist -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(531, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 33);
            this.label10.TabIndex = 36;
            this.label10.Text = "All songs - ";
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.saveButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.save_icon_icon_with_png_and_vector_format_for_free_unlimited_270528;
            this.saveButton.Location = new System.Drawing.Point(890, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 25);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save All";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moreInfoButton
            // 
            this.moreInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moreInfoButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.moreInfoButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources._38537d7f770f46341321a53ed988c219;
            this.moreInfoButton.Location = new System.Drawing.Point(532, 835);
            this.moreInfoButton.Name = "moreInfoButton";
            this.moreInfoButton.Size = new System.Drawing.Size(84, 23);
            this.moreInfoButton.TabIndex = 40;
            this.moreInfoButton.Text = "More Info";
            this.moreInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.moreInfoButton.UseVisualStyleBackColor = true;
            this.moreInfoButton.Click += new System.EventHandler(this.moreInfoButton_Click);
            // 
            // runInDesktopButton
            // 
            this.runInDesktopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.runInDesktopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runInDesktopButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.runInDesktopButton.Image = ((System.Drawing.Image)(resources.GetObject("runInDesktopButton.Image")));
            this.runInDesktopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runInDesktopButton.Location = new System.Drawing.Point(788, 72);
            this.runInDesktopButton.Name = "runInDesktopButton";
            this.runInDesktopButton.Size = new System.Drawing.Size(206, 27);
            this.runInDesktopButton.TabIndex = 41;
            this.runInDesktopButton.Text = "Run BeatSaber in desktop mode";
            this.runInDesktopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.runInDesktopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.runInDesktopButton.UseVisualStyleBackColor = true;
            this.runInDesktopButton.Click += new System.EventHandler(this.runInDesktopButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Linen;
            this.label11.Location = new System.Drawing.Point(532, 781);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Added:";
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Image = global::BeatSaber_Playlist_Master_V2.Properties.Resources.exit_icon_icons_com_70975;
            this.exitButton.Location = new System.Drawing.Point(919, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 43;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1006, 926);
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
            this.Name = "Form1";
            this.Text = "Playlist Saber";
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
        private System.Windows.Forms.TreeView playlistTreeView;
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
    }
}

