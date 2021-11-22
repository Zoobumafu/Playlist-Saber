using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeatSaverSharp;

namespace BeatSaber_Playlist_Master_V2
{
    public partial class songFinder : Form
    {
        BeatSaver beatSaver;
        Form1 mainForm;
        Downloader thisDownloader;
        List<PlaylistSong> songList; 

        public songFinder(Form1 form1, Downloader downloader)
        { 
            InitializeComponent();
            // Get access to main form resources
            mainForm = form1;

            // Populate Playlists treeview
            mainForm.populatePlaylists(mainForm.playlists, playlistTreeView, true);

            // Add headers for the list
            /*
             * 1 - Song Name
             * 2 - Rating
             * 3 - Author
             * 4 - Difficulties
             * 5 - Download
             */

            // Getting API controller
            BeatSaverOptions options = new BeatSaverOptions(Data.appName, Data.version);
            beatSaver = new BeatSaver(options);


            //populateGridView();
            //songListView.Rows.Add("name1", "name2", "name3", "name4");
            songList = new List<PlaylistSong>();

            thisDownloader = mainForm.downloader;


        }

        private async void getSearchResults(string searchKey = null, bool latest = true, string rating = null)
        {
            BeatSaverSharp.Models.Pages.Page page = null;
            dataGridSongSearch.Enabled = false;
            if (latest)
            {
                page = await beatSaver.LatestBeatmaps(/* optionals for automapper querying */);
            }
            else
            {
                
            }

            populateGridView(page);
            dataGridSongSearch.Enabled = true;
        }

        private async void populateGridView(BeatSaverSharp.Models.Pages.Page page)
        {
            dataGridSongSearch.Rows.Clear();
            // Generate a list of songs
            for (int i = 0; i < page.Beatmaps.Count; i++)
            {
                songList.Clear();
                PlaylistSong song = new PlaylistSong();
                song.name = page.Beatmaps[i].Name;
                song.uploader = page.Beatmaps[i].Uploader.Name;
                song.hash = page.Beatmaps[i].LatestVersion.Hash;
                song.key = page.Beatmaps[i].LatestVersion.Key;
                song.length = (int)page.Beatmaps[i].LatestVersion.Difficulties[0].Seconds;
                var  myImage = await page.Beatmaps[i].LatestVersion.DownloadCoverImage();
                song.image = (Bitmap)((new ImageConverter()).ConvertFrom(myImage));
                songList.Add(song);
            }
            for (int i = 0; i < songList.Count; i++)
            {
                dataGridSongSearch.Rows.Add(
                    // Picturebox
                    songList[i].image,
                    // Name
                    songList[i].name,
                    // Author
                    songList[i].uploader,
                    // Song, 
                    songList[i].length / 60 + ":" + songList[i].length % 60,
                    "",
                    songList[i].difficultiesFromBeatSaver

                    );
                dataGridSongSearch.Rows[i].Tag = songList[i];
                // Name
            }
        }

        private void playlistTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void songListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Playlist playlistToSend = (Playlist)playlistTreeView.SelectedNode.Tag;
            MessageBox.Show(playlistToSend.playlistTitle);
            thisDownloader.addSongToQueue((PlaylistSong)dataGridSongSearch.Rows[e.RowIndex].Tag, playlistToSend);
        }
        

        private void searchButton_Click(object sender, EventArgs e)
        {
            getSearchResults(null, true);
        }

        private void dataGridSongSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Playlist playlistToSend = (Playlist)playlistTreeView.SelectedNode.Tag;
            thisDownloader.addSongToQueue((PlaylistSong)dataGridSongSearch.Rows[e.RowIndex].Tag, playlistToSend);
        }
    }
}
