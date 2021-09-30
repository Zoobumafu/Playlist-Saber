using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatSaber_Playlist_Master_V2
{
    public partial class SongDetailsForm : Form
    {
        public SongDetailsForm(PlaylistSong song, Color nodeColor, List<Playlist> playlists = null)
        {
            InitializeComponent();
            songDetailsFormNameLabel.Text = song.songName;
            songDetailsFormAuthorLabel.Text = song.uploader;
            songDetailsFormSongCreatorLabel.Text = song.artist;
            songDetailsFormDifficultiesLabel.Text = song.GetDifficultiesString();

            if (song.file != null)
            {
                songDetailsFormMapVersionLabel.Text = song.file._version;
                songDetailsFormDefaultEvironment.Text = song.file._environmentName;
            }

            // Get and set image
            
            songDetailsFormPictureBox.Image = song.getSongImage();
            


            // Get and display the playlists the song appears in
            List<Playlist> songAppearsInList = new List<Playlist>();
            if (playlists != null)
            {
                // Find the playlists
                for (int i = 0; i < playlists.Count; i++)
                {
                    for (int j = 0; j < playlists[i].songs.Count; j++)
                    {
                        if (song.hash == playlists[i].songs[j].hash)
                        {
                            songAppearsInList.Add(playlists[i]);
                            continue;
                        }
                    }
                }

                // Fill the treeview
                for (int i = 0; i < songAppearsInList.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Tag = songAppearsInList[i];
                    node.Text = songAppearsInList[i].playlistTitle;
                    node.ForeColor = nodeColor;
                    songDetailsFormPlaylistsTreeView.Nodes.Add(node);
                }
            }
        }
    }
}
