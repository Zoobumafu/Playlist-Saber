﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Windows.Forms;
using BeatSaverSharp;
using System.Drawing;

namespace BeatSaber_Playlist_Master_V2
{
    // *** UI ***
    // Make the selected playlist text bigger OR the background different
    // Keep colorings saved in a text file, in order to keep playlists coloring the same from session to session.
    // Help Button on top with screenshots
    
    
    public partial class Form1 : Form
    {

        public List<Playlist> playlists = new List<Playlist>();
        public List<PlaylistSong> allSongs = new List<PlaylistSong>();

        // Flag to hold the last selected playlist / song
        Playlist selectedPlaylist = null;
        PlaylistSong lastSelectedSong = null;

        public Form1()
        {

            InitializeComponent();

            // Startup processes

            // Find directory
            FindBeatSaberDirectory();

            // Read previous playlists into object
            ReadPlaylist(playlists);

            // Find all song FILES in directory
            FindAllSongs(allSongs, playlists);

            AssociatePlaylistsWithSong();

            // Check and merge songs in the playlist with the song files found.
            MergeSongs(allSongs, playlists);

            // Populate GUI
            populatePlaylists(playlists);
            populateAllSongsForm();


            // Assaigning BeatSaverSharp parameters
            options = new HttpOptions(Data.appName, Data.version);
            beatSaver = new BeatSaver(options);

            // UI 
            // Removing top bar
            this.ControlBox = false;
            this.Text = String.Empty;


        }

        
        /// <summary>
        /// Add playlists to the treeview control
        /// </summary>
        /// <param name="playlists"></param>
        public void populatePlaylists(List<Playlist> playlists)
        {
            playlistTreeView.Nodes.Clear();
            for (int i = 0; i < playlists.Count; i++)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = playlists[i].playlistTitle;
                treeNode.Tag = playlists[i];
                treeNode.ForeColor = Playlist.getColor();
                playlistTreeView.Nodes.Add(treeNode);
            }
        }

        /// <summary>
        /// Helper function for getting search results
        /// </summary>
        public List<PlaylistSong> searchResults(string searchKey = null)
        {
            List<PlaylistSong> songsToList = new List<PlaylistSong>();
            for (int i = 0; i < allSongs.Count; i++)
            {
                bool addSong = true;
                if (searchKey != null)
                {
                    //Filter results, if search key is provided.
                    if (allSongs[i].songName.IndexOf(searchKey, StringComparison.OrdinalIgnoreCase) >= 0 == false &&
                        allSongs[i].artist.IndexOf(searchKey, StringComparison.OrdinalIgnoreCase) >= 0 == false &&
                        allSongs[i].uploader.IndexOf(searchKey, StringComparison.OrdinalIgnoreCase) >= 0 == false)
                    {
                        addSong = false;
                    }
                }

                //Check if the song is already in playlist in case of the tickbox is checked, if it is, than filter it out
                if (unplaylistedCheckbox.Checked == true)
                {
                    if (isAlreadyInPlaylist(allSongs[i]))
                    {
                        addSong = false;
                    }
                }
                
                if (addSong)
                {
                    songsToList.Add(allSongs[i]);
                }

            }
            return songsToList;
        }

        // Check if song is already in playlist
        // TO DO - This method is FINE!, the objects in allSongs are not the same as the ones inside the playlists
        bool isAlreadyInPlaylist(PlaylistSong song)
        {
            for (int i = 0; i < playlists.Count; i++)
                {
                // Start checking from precise measurements if they are available, if not, move on to less precise ones
                for (int j = 0; j < playlists[i].songs.Count; j++)
                    {
                    if (song.Equals(playlists[i].songs[j]))
                    {
                        return true;
                    }

                    // Check by unique Hash
                    if (song.hash != null && playlists[i].songs[j].hash != null)
                    {
                        if (song.hash == playlists[i].songs[j].hash)
                            return true;
                    }
                    
                    // Check by unique Key
                    if (song.key != null && playlists[i].songs[j].key != null)
                    {
                        if (song.key == playlists[i].songs[j].key)
                            return true;
                    }

                    // Check by non unique parameters
                    if (song.songName == playlists[i].songs[j].songName && song.artist == playlists[i].songs[j].artist && song.uploader == playlists[i].songs[j].uploader)
                        return true;
                }
            }
            return false;
        }

        public List<PlaylistSong> populateAllSongsForm(string searchKey = null)
        {
            // Clear TreeView
            allSongsTreeView.Nodes.Clear();

            List<PlaylistSong> songsToList = searchResults(searchKey);

            // Populate TreeView

            // Sort the found list
            List<PlaylistSong> sortedList;
            if (nameRadioButton.Checked == true)
            {
                sortedList = songsToList.OrderBy(x => x.songName).ToList();
            }
            else if (dateRadioButton.Checked == true)
            {
                List<PlaylistSong> datelessSongs = new List<PlaylistSong>();
                foreach (PlaylistSong song in songsToList)
                {
                    if (song.file == null)
                    {
                        datelessSongs.Add(song);
                        songsToList.Remove(song);
                    }
                }
                sortedList = songsToList.OrderBy(x => x.file.lastModified).ToList();
                sortedList.Reverse();
                foreach (PlaylistSong datelessSong in datelessSongs)
                {
                    sortedList.Add(datelessSong);
                }
            }
            else
            {
                sortedList = songsToList;
            }

            foreach (PlaylistSong song in sortedList)
            {
                TreeNode node = new TreeNode();
                node.Tag = song;
                node.Text = song.songName;
                allSongsTreeView.Nodes.Add(node);
            }

            NumOfSongsLabel.Text = "" + sortedList.Count;

            return sortedList;
        }

        // Update songs in Playlists TreeView after playlist selection
        public void PopulateSongsInPlaylist()
        {
            songsInPlaylistTreeView.Nodes.Clear();
            Playlist currentPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;
            if (playlistTreeView.SelectedNode != null)
            {
                for (int i = 0; i < currentPlaylist.songs.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Tag = currentPlaylist.songs[i];
                    node.Text = currentPlaylist.songs[i].songName;
                    songsInPlaylistTreeView.Nodes.Add(node);
                }
            }
        }

        // Create a playlist by opening the New Playlist Form
        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            NewPlaylistForm form = new NewPlaylistForm(this);
            form.ShowDialog();
        }

        // Populate playlist information textboxes, and enable them on first use.
        private void playlistTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PopulateSongsInPlaylist();
            selectedPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;

            playlistNameTextBox.Enabled = true;
            playlistAuthorTextBox.Enabled = true;
            playlistDescriptionTextBox.Enabled = true;
            playlistPictureBox.Enabled = true;

            playlistNameTextBox.Text = selectedPlaylist.playlistTitle;
            playlistAuthorTextBox.Text = selectedPlaylist.playlistAuthor;
            playlistDescriptionTextBox.Text = selectedPlaylist.description;
            if (selectedPlaylist.imageFile != null)
            {
                playlistPictureBox.Image = selectedPlaylist.imageFile;
            }
            else
            {
                playlistPictureBox.Image = Properties.Resources.ClickMe;
            }
        }

        private void allSongsTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddSong();
        }

        private void songsInPlaylistTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoveSong();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveAll();
        }

        // Save textbox input into playlist
        private void playlistNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(playlistNameTextBox.Text))
            {
                selectedPlaylist.playlistTitle = playlistNameTextBox.Text;
                playlistTreeView.SelectedNode.Text = playlistNameTextBox.Text;
            }
        }

        private void playlistAuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedPlaylist.playlistAuthor = playlistAuthorTextBox.Text;
        }

        private void playlistDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedPlaylist.description = playlistDescriptionTextBox.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setImage();
        }

        private void newPlaylistButton_Click(object sender, EventArgs e)
        {
            NewPlaylistForm playlistForm = new NewPlaylistForm(this);
            playlistForm.ShowDialog();
        }

        private void playlistDeleteButton_Click(object sender, EventArgs e)
        {
            if (playlistTreeView.SelectedNode != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the playlist " + selectedPlaylist.playlistTitle
                + "? This cannot be undone!", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(selectedPlaylist.filePath);
                    playlists.Remove(selectedPlaylist);
                    playlistTreeView.SelectedNode.Remove();
                    populatePlaylists(playlists);
                }
            }
            else
            {
                MessageBox.Show("Please select a playlist first");
            }
            
        }

        private void allSongsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            updateSongDetails(allSongsTreeView.SelectedNode);
            PlaylistSong temp = (PlaylistSong)allSongsTreeView.SelectedNode.Tag;
            if (allSongsTreeView.SelectedNode != null)
            {
                lastSelectedSong = (PlaylistSong)allSongsTreeView.SelectedNode.Tag;
            }
        }

        private void songsInPlaylistTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            updateSongDetails(songsInPlaylistTreeView.SelectedNode);
            if (songsInPlaylistTreeView.SelectedNode != null)
            {
                lastSelectedSong = (PlaylistSong)songsInPlaylistTreeView.SelectedNode.Tag;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != null)
            {
                populateAllSongsForm(searchTextBox.Text);
            }
            else
            {
                populateAllSongsForm();
            }
        }

        private void dateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != null)
            {
                populateAllSongsForm(searchTextBox.Text);
            }
            else
            {
                populateAllSongsForm();
            }
        }

        private void nameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != null)
            {
                populateAllSongsForm(searchTextBox.Text);
            }
            else
            {
                populateAllSongsForm();
            }
        }

        private void addResultsButton_Click(object sender, EventArgs e)
        {
            List<PlaylistSong> songsToAdd = searchResults(searchTextBox.Text);
            if (playlistTreeView.SelectedNode != null)
            {
                foreach (PlaylistSong song in songsToAdd)
                {
                    AddSong(song, (Playlist)playlistTreeView.SelectedNode.Tag);
                }
            }
            else
            {

            }
        }

        private void unplaylistedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            populateAllSongsForm();
        }

        void updateSongDetails(TreeNode node)
        {
            PlaylistSong currentSong = (PlaylistSong)node.Tag;
            songNameLabel.Text = currentSong.songName;
            songAuthorLabel.Text = "by " + currentSong.uploader;


            // Set Image
            if (currentSong.file != null)
            {
                hashLabel.Text = currentSong.hash;
                lastModifiedLabel.Text = currentSong.file.lastModified.ToString();
                if (currentSong.file._coverImageFilename != null)
                {
                    //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(allSongs[i].file.filePath + @"\" + allSongs[i].file._coverImageFilename);
                    try
                    {
                        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(currentSong.file.folderPath + @"\" + currentSong.file._coverImageFilename);
                        songPictureBox.Image = bitmap;
                    }
                    catch (Exception e)
                    {
                        songPictureBox.Image = null;
                        Console.WriteLine("Error finding image in " + currentSong.songName + "\n" + e.Message);
                    }
                }
            }
            else
            {
                lastModifiedLabel.Text = "";
                hashLabel.Text = "";
                songPictureBox.Image = null;
            }
        }

        private void clearPlaylistButton_Click(object sender, EventArgs e)
        {
            if (playlistTreeView.SelectedNode != null)
            {
                if (MessageBox.Show("This will remove all the songs from this playlist \n The song files will not be deleted", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Playlist playlistToClear = (Playlist)playlistTreeView.SelectedNode.Tag;
                    playlistToClear.songs.Clear();
                    PopulateSongsInPlaylist();

                }
            }
        }

        private void openSongFolderButton_Click(object sender, EventArgs e)
        {
            if (allSongsTreeView.SelectedNode != null)
            {
                if (lastSelectedSong.file != null)
                {
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", lastSelectedSong.file.folderPath);
                }
                else
                {
                    MessageBox.Show("Could not find the location of this song \nIt is likely that this song exists in the playlist, but not in your songs folder");
                }
            }
            
        }

        private void removeDuplicatesButton_Click(object sender, EventArgs e)
        {
            if (selectedPlaylist != null)
            {
                selectedPlaylist.songs = selectedPlaylist.songs.Distinct().ToList();
                PopulateSongsInPlaylist();
            }
        }

        private void playlistTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.Label))
            {
                MessageBox.Show("Playlist name cannot be empty");
                playlistTreeView.SelectedNode.Text = selectedPlaylist.playlistTitle;
            }
            else
            {
                selectedPlaylist.playlistTitle = e.Label;
                playlistNameTextBox.Text = e.Label;
            }
            
        }
        // Changing the color of the delete playlist button to red when hovering over it
        private void playlistDeleteButton_MouseHover(object sender, EventArgs e)
        {
            playlistDeleteButton.BackColor = Color.Red;
        }

        // Reverting to previous color
        private void playlistDeleteButton_MouseLeave(object sender, EventArgs e)
        {
            playlistDeleteButton.BackColor = Color.FromArgb(255, 192, 192);
        }
    }
}