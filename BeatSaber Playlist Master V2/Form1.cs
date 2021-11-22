using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using BeatSaverSharp;


namespace BeatSaber_Playlist_Master_V2
{
    // *** UI ***
    // Help Button on top with screenshots
    // Change the playlist image icon to upload icon 
    // Add a label that a song is missing it's file.
    // Hide the song details and playlist details by a toggle button
    // Increase text size for search functions


    //*** Functionality ***
    // Add search functionality to playlists
    // Scroll down to the button of the playlist treeview when adding a song
    // Add the ability to the know which BeatSaber directory you are working with



    public partial class Form1 : Form
    {

        public List<Playlist> playlists = new List<Playlist>();
        public List<PlaylistSong> allSongs = new List<PlaylistSong>();

        // Flag to hold the last selected playlist / song
        Playlist selectedPlaylist = null;
        PlaylistSong lastSelectedSong = null;

        // UI helper values to enable dragging of the form
        Point _start_point;
        bool _dragging;

        // Helper value for brush, to change the marking color of a treenode
        SolidBrush brush;
        Color nodeForeColor;

        // Object to download songs
        public Downloader downloader;

        // Creating the finder form
        songFinder songFinder;
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
            populatePlaylists(playlists, playlistTreeView);
            populateAllSongsForm();


            // Assaigning BeatSaverSharp parameters
            downloader = new Downloader(this);
            
            // UI 
            // Removing top bar
            this.ControlBox = false;
            this.Text = String.Empty;

            // Coloring the treenodes - 
            // Background color
            brush = new SolidBrush(Color.FromArgb(21, 60, 151));
            // Text color
            //nodeForeColor = Color.FromArgb(116, 118, 124); // Yellowish
            nodeForeColor = Color.FromArgb(247, 244, 234); // Grayish

            // Change the back color of the form so disabled controls inherit it
            playlistAuthorTextBox.BackColor = Color.FromArgb(32, 34, 37);

            // Set the image of the 'Launch in Windows mode' option properly
            runInDesktopButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            runInDesktopButton.TextAlign = ContentAlignment.MiddleCenter;
            runInDesktopButton.ImageAlign = ContentAlignment.MiddleCenter;

            // Creating the song searcher form
            songFinder = new songFinder(this, downloader);

        }


        #region Search and treeview populate functions

        /// <summary>
        /// Add playlists to the treeview control
        /// </summary>
        /// <param name="playlists"></param>
        public void populatePlaylists(List<Playlist> playlists, TreeView treeView, bool addOutOfPlaylistNode = false)
        {
            treeView.Nodes.Clear();
            if (addOutOfPlaylistNode)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = "Don't add to playlist";
                treeNode.ForeColor = Playlist.getColor();
                treeView.Nodes.Add(treeNode);
            }
            for (int i = 0; i < playlists.Count; i++)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = playlists[i].playlistTitle;
                treeNode.Tag = playlists[i];
                treeNode.ForeColor = Playlist.getColor();
                treeView.Nodes.Add(treeNode);
            }
        }


        /// <summary>
        /// Helper function for getting search results
        /// </summary>
        public List<PlaylistSong> searchResults(string searchKey = null, string[] modes = null)
        {
            List<PlaylistSong> songsToList = new List<PlaylistSong>();
            for (int i = 0; i < allSongs.Count; i++)
            {
                bool addSong = true;
                if (searchKey != null)
                {
                    //Filter results, if search key is provided.
                    if (allSongs[i].name.IndexOf(searchKey, StringComparison.OrdinalIgnoreCase) >= 0 == false &&
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

                if (modes != null)
                {
                    bool hasMode = true;
                    if (allSongs[i].file != null)
                    {
                        /*for (int j = 0; j < modes.Length; j++)
                        {
                            for (int k = 0; k < allSongs[i].file._difficultyBeatmapSets.Length; k++)
                            {
                                if (modes[j] == allSongs[i].file._difficultyBeatmapSets[k]._beatmapCharacteristicName)
                                {
                                    hasMode = false;
                                }
                            }
                        }*/

                        for (int j = 0; j < modes.Length; j++)
                        {
                            bool modeFound = false;
                            for (int k = 0; k < allSongs[i].file._difficultyBeatmapSets.Length; k++)
                            {
                                if (allSongs[i].file._difficultyBeatmapSets[k]._beatmapCharacteristicName == modes[j])
                                {
                                    modeFound = true;
                                }
                            }
                            if (!modeFound)
                            {
                                addSong = false;
                            }
                        }
                    }
                    else
                    {
                        addSong = false;
                    }

                    if (!hasMode)
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



        // Populate playlist information textboxes, and enable them on first use.
        private void playlistTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PopulateSongsInPlaylist((Playlist)playlistTreeView.SelectedNode.Tag);
            selectedPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;

            playlistNameTextBox.Enabled = true;
            playlistAuthorTextBox.Enabled = true;
            playlistDescriptionTextBox.ReadOnly = false;
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
                    if (song.name == playlists[i].songs[j].name && song.artist == playlists[i].songs[j].artist && song.uploader == playlists[i].songs[j].uploader)
                        return true;
                }
            }
            return false;
        }

        public string[] getModeFilter()
        {
            List<string> difficulties = new List<string>();

            if (Data.standardMode)
            {
                difficulties.Add("Standard");
            }
            if (Data.OneSaberMode)
            {
                difficulties.Add("OneSaber");
            }
            if (Data.ninetyDegreesMode)
            {
                difficulties.Add("90Degree");
            }
            if (Data.threeSixtyDegreesMode)
            {
                difficulties.Add("360Degree");
            }
            if (Data.lightShowMode)
            {
                difficulties.Add("Lightshow");
            }
            if (Data.noArrowsMode)
            {
                difficulties.Add("NoArrows");
            }
            if (Data.otherMode)
            {
                difficulties.Add("Lightshow");
            }
            /*bool hasOtherMode = false;
            if (song.file != null)
            {
                for (int i = 0; i < song.file._difficultyBeatmapSets.Length; i++)
                {
                    if (!Data.modeNames.Contains(song.file._difficultyBeatmapSets[i]._beatmapCharacteristicName))
                    {
                        hasOtherMode = true;
                    }

                }
            }*/

            // THE LINES BELOW CANNOT BE IMPLEMENTED THIS WAY - TO-DO

            /*
            if (hasOtherMode)
            {
                difficulties.Add("Other");
            }
            */

            return difficulties.ToArray();
        }

        public List<PlaylistSong> populateAllSongsForm(string searchKey = null)
        {
            // Clear TreeView
            allSongsTreeView.Nodes.Clear();

            // Check for difficulties filter, and send them in as parameter
            string[] modeFilter = getModeFilter();

            List<PlaylistSong> songsToList = searchResults(searchKey, modeFilter);

            // Populate TreeView

            // Sort the found list
            List<PlaylistSong> sortedList;
            if (nameRadioButton.Checked == true)
            {
                sortedList = songsToList.OrderBy(x => x.name).ToList();
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
                node.Text = song.name;
                allSongsTreeView.Nodes.Add(node);
            }

            NumOfSongsLabel.Text = "" + sortedList.Count;

            return sortedList;
        }

        // Update songs in Playlists TreeView after playlist selection
        public void PopulateSongsInPlaylist(Playlist playlist)
        {
            songsInPlaylistTreeView.Nodes.Clear();
            //Playlist currentPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;
            if (playlistTreeView.SelectedNode != null)
            {
                for (int i = 0; i < playlist.songs.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Tag = playlist.songs[i];
                    node.Text = playlist.songs[i].name;
                    songsInPlaylistTreeView.Nodes.Add(node);
                }
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
            List<PlaylistSong> songsToAdd = searchResults(searchTextBox.Text, getModeFilter());
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
            songNameLabel.Text = currentSong.name;
            songAuthorLabel.Text = "by " + currentSong.uploader;

            if (currentSong.file != null)
            {
                // Set Image
                hashLabel.Text = currentSong.hash;
                lastModifiedLabel.Text = currentSong.file.lastModified.ToString();
                
                if (currentSong.getSongImage() != null)
                {
                    songPictureBox.Image = currentSong.getSongImage();
                }
                else
                {
                    songPictureBox.Image = null;
                }
                
            }
            else
            {
                lastModifiedLabel.Text = "";
                hashLabel.Text = "";
                songPictureBox.Image = null;
            }

            // Hide or show download button if the files are missing
            if (currentSong.file != null)
            {
                downloadSongButton.Visible = false;
            }
            else if (downloader.isInQueue(currentSong))
            {
                downloadSongButton.Visible = false;
            }
            else
            {
                downloadSongButton.Visible = true;
            }
            

/*            // Hide or show donloading notification
            if (downloader.isInQueue(currentSong))
            {
                downloadingSongLabel.Visible = true;
            }
            else
            {
                downloadingSongLabel.Visible = false;
            }*/
        }



        #endregion

        #region Other miscellaneous button functions 


        private void changeInstallLocation_Click(object sender, EventArgs e)
        {

            using (var pathSelectionDialog = new FolderBrowserDialog())
            {
                DialogResult result = pathSelectionDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(pathSelectionDialog.SelectedPath))
                {
                    if (File.Exists(pathSelectionDialog.SelectedPath + @"\Beat Saber.exe"))
                    {
                        Properties.Settings.Default.InstallPath = pathSelectionDialog.SelectedPath;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Path changed successfuly, application will now restart");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Invalid path - Please enter the path that contains Beat Saber.exe");
                    }
                }
            }

        }

        // Event to run when the application exits - saves the user path setting
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        // Link label function to open Github page
        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = @"https://github.com/Zoobumafu/Playlist-Saber",
                    UseShellExecute = true
                };
                Process.Start(psi);
                //System.Diagnostics.Process.Start(urlEncoded);
            }
            catch
            {
                MessageBox.Show("There was an error opening the site, could it be that you don't have a default browser? \nYou can find us by searching 'Playlist Saber' on Google");
            }

            //System.ComponentModel.Win32Exception: 'The system cannot find the file specified.'
        }

        // Check if song is already in playlist        
        // Create a playlist by opening the New Playlist Form
        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            NewPlaylistForm form = new NewPlaylistForm(this);
            form.ShowDialog();
        }

        private void allSongsTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddSong();
            playlistTreeView.Nodes[0].EnsureVisible();
        }

        private void songsInPlaylistTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoveSong();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveAll();
            MessageBox.Show("All playlists saved successfully");
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
                + "? \n This cannot be undone!", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(selectedPlaylist.filePath);
                    playlists.Remove(selectedPlaylist);
                    playlistTreeView.SelectedNode.Remove();
                    populatePlaylists(playlists, playlistTreeView);
                    Data.isSaved = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a playlist first");
            }

        }

        private void removeDuplicatesButton_Click(object sender, EventArgs e)
        {
            if (selectedPlaylist != null)
            {
                selectedPlaylist.songs = selectedPlaylist.songs.Distinct().ToList();
                PopulateSongsInPlaylist((Playlist) playlistTreeView.SelectedNode.Tag);
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
                    PopulateSongsInPlaylist((Playlist)playlistTreeView.SelectedNode.Tag);

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

        // The next 3 events allow the form to be dragged and dropped

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        

        


        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        // TO - DO - pop up a dialog box which shows the name, author, difficulty of a level, hash code, etc.
        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            SongDetailsForm songDetailsForm = new SongDetailsForm(lastSelectedSong, nodeForeColor, playlists);
            songDetailsForm.Show();
        }

        private void runInDesktopButton_Click(object sender, EventArgs e)
        {
            // This is currently bugged and therefore invisible.
            MessageBox.Show("\"" + Data.installPath + @"\Beat Saber.exe" + "\"" + " fpfc");
            Process.Start("\"" + Data.installPath + @"\Beat Saber.exe" + "\"", " fpfc");
        }

        public void Exit()
        {
            if (Data.isSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save before leaving?", "You have unsaved data!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saveAll();
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        #endregion

        #region code to design the look of the treeviews

        private void Form1_Load(object sender, EventArgs e)
        {
            allSongsTreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            songsInPlaylistTreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }

        private void allSongsTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Change the coloring of selected treenode
            if (e.Node.IsSelected)
            {
                if (allSongsTreeView.Focused)
                    e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Change the coloring of the selected treenode when the treeview isn't focused

            if (e.Node == null) return;

            // if treeview's HideSelection property is "True", 
            // this will always returns "False" on unfocused treeview
            var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
            var unfocused = !e.Node.TreeView.Focused;

            // we need to do owner drawing only on a selected node
            // and when the treeview is unfocused, else let the OS do it for us
            if (selected && unfocused)
            {
                var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
                e.Graphics.FillRectangle(SystemBrushes.WindowText, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, nodeForeColor);
            }
            else
            {
                e.DrawDefault = true;
            }


            TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Node.Bounds, nodeForeColor);
        }

        private void songsInPlaylistTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Change the coloring of selected treenode
            if (e.Node.IsSelected)
            {
                if (songsInPlaylistTreeView.Focused)
                    e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Change the coloring of the selected treenode when the treeview isn't focused


                if (e.Node == null) return;

                // if treeview's HideSelection property is "True", 
                // this will always returns "False" on unfocused treeview
                var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
                var unfocused = !e.Node.TreeView.Focused;

                // we need to do owner drawing only on a selected node
                // and when the treeview is unfocused, else let the OS do it for us
                if (selected && unfocused)
                {
                    var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
                    e.Graphics.FillRectangle(SystemBrushes.WindowText, e.Bounds);
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, nodeForeColor);
                }
                else
                {
                    e.DrawDefault = true;
                }

            TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Node.Bounds, nodeForeColor);
        }

        #endregion

        #region Buttons to control mode filter flags.

        private void noArrowsModeButton_Click(object sender, EventArgs e)
        {
            if (!Data.noArrowsMode)
            {
                Data.noArrowsMode = true;
                noArrowsModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.No_Arrows_Clicked;
            }
            else
            {
                Data.noArrowsMode = false;
                noArrowsModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.No_Arrows_Unclicked;

            }

            populateAllSongsForm(searchTextBox.Text);

            // Add code to change the image of the button.
        }

        private void oneSaberModeButton_Click(object sender, EventArgs e)
        {
            if (!Data.OneSaberMode)
            {
                Data.OneSaberMode = true;

                oneSaberModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.One_Saber_Clicked;
            }
            else
            {
                Data.OneSaberMode = false;

                oneSaberModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.One_Saber_Unclicked;
            }

            populateAllSongsForm(searchTextBox.Text);

            // Add code to change the image of the button.
        }

        private void ninetyDegreeModeButton_Click(object sender, EventArgs e)
        {
            if (!Data.ninetyDegreesMode)
            {
                Data.ninetyDegreesMode = true;

                ninetyDegreeModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.nintyDegreesClicked;
            }
            else
            {
                Data.ninetyDegreesMode = false;

                ninetyDegreeModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.nintyDegreesUnclicked;

            }

            populateAllSongsForm(searchTextBox.Text);

            // Add code to change the image of the button.
        }

        private void threeSixyModeButton_Click(object sender, EventArgs e)
        {
            if (!Data.threeSixtyDegreesMode)
            {
                Data.threeSixtyDegreesMode = true;

                threeSixyModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.threeSixtyClicked;
            }
            else
            {
                Data.threeSixtyDegreesMode = false;

                threeSixyModeButton.Image = BeatSaber_Playlist_Master_V2.Properties.Resources.threeSixtyUnclicked;

            }

            populateAllSongsForm(searchTextBox.Text);

            // Add code to change the image of the button.
        }

        private void lightShowModeButton_Click(object sender, EventArgs e)
        {
            if (!Data.lightShowMode)
            {
                Data.lightShowMode = true;

                lightShowModeButton.BackColor = Color.Snow;

            }
            else
            {
                Data.lightShowMode = false;

                lightShowModeButton.BackColor = Color.Transparent;
            }

            populateAllSongsForm(searchTextBox.Text);

            // Add code to change the image of the button.
        }


        #endregion

        private void downloadSongButton_Click(object sender, EventArgs e)
        {
            downloader.addSongToQueue(lastSelectedSong);
            downloadSongButton.Visible = false;
            downloadingSongLabel.Visible = true;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            PreviewPlayer player = new PreviewPlayer(lastSelectedSong);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openSongFinderButton_Click(object sender, EventArgs e)
        {
            songFinder.ShowDialog();
        }

        // ALLSONGS DOES NOT REGISTER SONGS THAT ARE IN PLAYLIST, BUT NOT IN THE FOLDER.
        private void downloadAllMissingSongsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                for (int j = 0; j < playlists[i].songs.Count; j++)
                {
                    if (playlists[i].songs[j].file == null)
                    {
                        downloader.addSongToQueue(playlists[i].songs[j]);
                    }
                }
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
