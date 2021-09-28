
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
            this.saveButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.newPlaylistButton.Location = new System.Drawing.Point(12, 126);
            this.newPlaylistButton.Name = "newPlaylistButton";
            this.newPlaylistButton.Size = new System.Drawing.Size(245, 23);
            this.newPlaylistButton.TabIndex = 2;
            this.newPlaylistButton.Text = "New Playlist";
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
            this.songsInPlaylistTreeView.Size = new System.Drawing.Size(496, 369);
            this.songsInPlaylistTreeView.TabIndex = 3;
            this.songsInPlaylistTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.songsInPlaylistTreeView_AfterSelect);
            this.songsInPlaylistTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songsInPlaylistTreeView_MouseDoubleClick);
            // 
            // allSongsTreeView
            // 
            this.allSongsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.allSongsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allSongsTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.allSongsTreeView.HideSelection = false;
            this.allSongsTreeView.Location = new System.Drawing.Point(532, 175);
            this.allSongsTreeView.Name = "allSongsTreeView";
            this.allSongsTreeView.ShowLines = false;
            this.allSongsTreeView.ShowPlusMinus = false;
            this.allSongsTreeView.ShowRootLines = false;
            this.allSongsTreeView.Size = new System.Drawing.Size(462, 528);
            this.allSongsTreeView.TabIndex = 0;
            this.allSongsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.allSongsTreeView_AfterSelect);
            this.allSongsTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allSongsTreeView_MouseDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(532, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(462, 133);
            this.saveButton.TabIndex = 4;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // playlistDescriptionTextBox
            // 
            this.playlistDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistDescriptionTextBox.Enabled = false;
            this.playlistDescriptionTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.playlistDescriptionTextBox.Location = new System.Drawing.Point(12, 404);
            this.playlistDescriptionTextBox.Name = "playlistDescriptionTextBox";
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
            this.playlistNameTextBox.Location = new System.Drawing.Point(65, 335);
            this.playlistNameTextBox.Name = "playlistNameTextBox";
            this.playlistNameTextBox.Size = new System.Drawing.Size(443, 16);
            this.playlistNameTextBox.TabIndex = 11;
            this.playlistNameTextBox.TextChanged += new System.EventHandler(this.playlistNameTextBox_TextChanged);
            // 
            // playlistAuthorTextBox
            // 
            this.playlistAuthorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistAuthorTextBox.Enabled = false;
            this.playlistAuthorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(124)))));
            this.playlistAuthorTextBox.Location = new System.Drawing.Point(65, 360);
            this.playlistAuthorTextBox.Name = "playlistAuthorTextBox";
            this.playlistAuthorTextBox.Size = new System.Drawing.Size(443, 16);
            this.playlistAuthorTextBox.TabIndex = 12;
            this.playlistAuthorTextBox.TextChanged += new System.EventHandler(this.playlistAuthorTextBox_TextChanged);
            // 
            // playlistDeleteButton
            // 
            this.playlistDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playlistDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.playlistDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.playlistDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playlistDeleteButton.Location = new System.Drawing.Point(266, 126);
            this.playlistDeleteButton.Name = "playlistDeleteButton";
            this.playlistDeleteButton.Size = new System.Drawing.Size(245, 23);
            this.playlistDeleteButton.TabIndex = 13;
            this.playlistDeleteButton.Text = "Delete Playlist";
            this.playlistDeleteButton.UseVisualStyleBackColor = false;
            this.playlistDeleteButton.Click += new System.EventHandler(this.playlistDeleteButton_Click);
            this.playlistDeleteButton.MouseLeave += new System.EventHandler(this.playlistDeleteButton_MouseLeave);
            this.playlistDeleteButton.MouseHover += new System.EventHandler(this.playlistDeleteButton_MouseHover);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.ForeColor = System.Drawing.Color.Linen;
            this.songNameLabel.Location = new System.Drawing.Point(532, 756);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(0, 15);
            this.songNameLabel.TabIndex = 14;
            // 
            // songAuthorLabel
            // 
            this.songAuthorLabel.AutoSize = true;
            this.songAuthorLabel.ForeColor = System.Drawing.Color.Linen;
            this.songAuthorLabel.Location = new System.Drawing.Point(532, 774);
            this.songAuthorLabel.Name = "songAuthorLabel";
            this.songAuthorLabel.Size = new System.Drawing.Size(0, 15);
            this.songAuthorLabel.TabIndex = 15;
            // 
            // songPictureBox
            // 
            this.songPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("songPictureBox.Image")));
            this.songPictureBox.Location = new System.Drawing.Point(816, 748);
            this.songPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(173, 148);
            this.songPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPictureBox.TabIndex = 16;
            this.songPictureBox.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.Location = new System.Drawing.Point(853, 148);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(141, 23);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(532, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sort By - ";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.Location = new System.Drawing.Point(532, 878);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(0, 15);
            this.lastModifiedLabel.TabIndex = 20;
            // 
            // addResultsButton
            // 
            this.addResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addResultsButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addResultsButton.Location = new System.Drawing.Point(863, 709);
            this.addResultsButton.Name = "addResultsButton";
            this.addResultsButton.Size = new System.Drawing.Size(131, 23);
            this.addResultsButton.TabIndex = 21;
            this.addResultsButton.Text = "Add Results to Playlist";
            this.addResultsButton.UseVisualStyleBackColor = true;
            this.addResultsButton.Click += new System.EventHandler(this.addResultsButton_Click);
            // 
            // unplaylistedCheckbox
            // 
            this.unplaylistedCheckbox.AutoSize = true;
            this.unplaylistedCheckbox.ForeColor = System.Drawing.Color.Linen;
            this.unplaylistedCheckbox.Location = new System.Drawing.Point(532, 712);
            this.unplaylistedCheckbox.Name = "unplaylistedCheckbox";
            this.unplaylistedCheckbox.Size = new System.Drawing.Size(199, 19);
            this.unplaylistedCheckbox.TabIndex = 22;
            this.unplaylistedCheckbox.Text = "Show Songs with no playlist only";
            this.unplaylistedCheckbox.UseVisualStyleBackColor = true;
            this.unplaylistedCheckbox.CheckedChanged += new System.EventHandler(this.unplaylistedCheckbox_CheckedChanged);
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(532, 878);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(0, 15);
            this.hashLabel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(757, 713);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Song Count - ";
            // 
            // NumOfSongsLabel
            // 
            this.NumOfSongsLabel.AutoSize = true;
            this.NumOfSongsLabel.ForeColor = System.Drawing.Color.Linen;
            this.NumOfSongsLabel.Location = new System.Drawing.Point(831, 713);
            this.NumOfSongsLabel.Name = "NumOfSongsLabel";
            this.NumOfSongsLabel.Size = new System.Drawing.Size(0, 15);
            this.NumOfSongsLabel.TabIndex = 25;
            // 
            // clearPlaylistButton
            // 
            this.clearPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearPlaylistButton.ForeColor = System.Drawing.Color.LightCoral;
            this.clearPlaylistButton.Location = new System.Drawing.Point(12, 874);
            this.clearPlaylistButton.Name = "clearPlaylistButton";
            this.clearPlaylistButton.Size = new System.Drawing.Size(129, 23);
            this.clearPlaylistButton.TabIndex = 26;
            this.clearPlaylistButton.Text = "Clear Playlist";
            this.clearPlaylistButton.UseVisualStyleBackColor = true;
            this.clearPlaylistButton.Click += new System.EventHandler(this.clearPlaylistButton_Click);
            // 
            // openSongFolderButton
            // 
            this.openSongFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openSongFolderButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.openSongFolderButton.Location = new System.Drawing.Point(532, 845);
            this.openSongFolderButton.Name = "openSongFolderButton";
            this.openSongFolderButton.Size = new System.Drawing.Size(131, 23);
            this.openSongFolderButton.TabIndex = 27;
            this.openSongFolderButton.Text = "Open Song Folder";
            this.openSongFolderButton.UseVisualStyleBackColor = true;
            this.openSongFolderButton.Click += new System.EventHandler(this.openSongFolderButton_Click);
            // 
            // removeDuplicatesButton
            // 
            this.removeDuplicatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeDuplicatesButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.removeDuplicatesButton.Location = new System.Drawing.Point(147, 874);
            this.removeDuplicatesButton.Name = "removeDuplicatesButton";
            this.removeDuplicatesButton.Size = new System.Drawing.Size(129, 23);
            this.removeDuplicatesButton.TabIndex = 28;
            this.removeDuplicatesButton.Text = "Remove Duplicates";
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
            this.nameRadioButton.Location = new System.Drawing.Point(51, 3);
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
            this.panel1.Location = new System.Drawing.Point(583, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 25);
            this.panel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(802, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1006, 910);
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
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView playlistTreeView;
        private System.Windows.Forms.Button newPlaylistButton;
        private System.Windows.Forms.TreeView songsInPlaylistTreeView;
        private System.Windows.Forms.TreeView allSongsTreeView;
        private System.Windows.Forms.Button saveButton;
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
    }
}

