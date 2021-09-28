using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeatSaber_Playlist_Master_V2
{
    public partial class NewPlaylistForm : Form
    {
        Form1 mainform;
        public string imageString;
        public Image imageFile;
        public NewPlaylistForm(Form1 callingForm)
        {
            InitializeComponent();
            mainform = callingForm;
        }

        


        

        /// <summary>
        /// Choose Image for the new playlist
        /// </summary>
        private void chooseImageButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image Files (*.bmp; *.jpg; *.jpeg,*.png)|*.BMP; *.JPG; *.JPEG; *.PNG";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        imageString = @"data:image/gif;base64," + Convert.ToBase64String(File.ReadAllBytes(@dlg.FileName));
                        pictureBox.Image = new Bitmap(dlg.FileName);
                        imageFile = new Bitmap(dlg.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error picking image " + ex.Message);
            }
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
                // Check if name already exists 
                bool uniqueName = true;
                foreach (Playlist playlist in mainform.playlists)
                {
                    if (nameTextbox.Text == playlist.playlistTitle)
                    {
                        uniqueName = false;
                    }
                }
                if (!uniqueName)
                {
                    MessageBox.Show("You already have a playlist with that name, choose a different one!");
                }
                else
                {
                    Playlist playlist = new Playlist(Data.installPath + @"\playlists\" + nameTextbox.Text + ".json");
                    playlist.playlistTitle = nameTextbox.Text;
                    if (descriptionTextBox.Text != null)
                    {
                        playlist.description = descriptionTextBox.Text;
                    }
                    if (authorTextbox.Text != null)
                    {
                        playlist.playlistAuthor = authorTextbox.Text;
                    }
                    if (imageString != null)
                    {
                        playlist.image = imageString;
                        playlist.imageFile = imageFile;
                    }
                    playlist.songs = new List<PlaylistSong>();
                    mainform.playlists.Add(playlist);
                    mainform.populatePlaylists(mainform.playlists);
                    this.Close();
                }

            }
        }
    }

