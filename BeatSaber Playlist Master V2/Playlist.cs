using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace BeatSaber_Playlist_Master_V2
{
    public class Playlist
    {
        // Count for text coloring
        public static int count = 0;

        public string playlistTitle { set; get; }
        public string playlistAuthor { set; get; }
        public string _filename { set; get; }
        public List<PlaylistSong> songs { set; get; }
        public string image { set; get; }

        public Image imageFile;

        public string filePath;
        public string description { set; get; }

        //Keep track of hashes
        public List<PlaylistSong> currentSongs = new List<PlaylistSong>();

        //public Image imageFile;
        //public void setImage()


        public Playlist(string path)
        {
            filePath = path;
        }

        /// <summary>
        /// Read 64bit base string into an image
        /// </summary>
        public void setImage()
        {
            if (image != null)
            {
                string cleanImageString = "";
                int index = this.image.LastIndexOf(@",");
                if (index > 0)
                    cleanImageString = this.image.Split(',').Last();

                byte[] bytes = Convert.FromBase64String(@cleanImageString);


                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    try
                    {
                        this.imageFile = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        ///<summary>
        ///Convert playlist song objects into hashes and than reset PlaylistSong list
        ///</summary>
        public void gatherSongList(List<PlaylistSong> allSongs)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].hash != null)
                {
                    for (int j = 0; j < allSongs.Count; j++)
                    {
                        if (songs[i].hash == allSongs[j].hash)
                        {
                            songs[i] = allSongs[j];
                        }
                    }
                }
            }
        }

        // Pick and return a color according to playlist count
        public static System.Drawing.Color getColor()
        {
            System.Drawing.Color color;

            switch (count % 8)
            {
                case 1:
                    color = System.Drawing.Color.Red;
                    break;
                case 2:
                    color = System.Drawing.Color.AliceBlue;
                    break;
                case 3:
                    color = System.Drawing.Color.Green;
                    break;
                case 4:
                    color = System.Drawing.Color.PaleVioletRed;
                    break;
                case 5:
                    color = System.Drawing.Color.Orange;
                    break;
                case 6:
                    color = System.Drawing.Color.MediumPurple;
                    break;
                case 7:
                    color = System.Drawing.Color.BlueViolet;
                    break;
                case 0:
                    color = System.Drawing.Color.DodgerBlue;
                    break;
                default:
                    color = System.Drawing.Color.DodgerBlue;
                    break;
            }
            count++;
            return color;

        }

    }
}
