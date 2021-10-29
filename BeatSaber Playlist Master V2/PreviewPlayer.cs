using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeatSaber_Playlist_Master_V2
{
    internal class PreviewPlayer
    {
        static WMPLib.WindowsMediaPlayer Player;
        static int playCount = 0;

        public PreviewPlayer(PlaylistSong song)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            getMusicFile(song);
        }

        private async void getMusicFile(PlaylistSong song)
        {
            try
            {
                var bitMap = await Downloader.beatSaver.BeatmapByHash(song.hash);
                if (bitMap != null)
                {
                    var musicFile = await bitMap.LatestVersion.DownloadPreview();
                    string filePath = Path.GetTempPath() + @"\PlaylistSaberMusicFile" + playCount + ".mp4";
                    playCount++;
                    File.WriteAllBytes(filePath, musicFile);
                    Player.URL = filePath;
                    Player.controls.play();
                    musicFile = null;
                }


                else
                {
                    MessageBox.Show("Could not fetch preview for this song, it may be caused by internet issues (either on your end, or BeatSaver's end. \nThis issue can also be appear if this version of the map does not exist on BeatSaver");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Generic error trying to play preview, it is likely caused by the corrupt song details, or error reaching the BeatSaver's servers\n" + e.Message);
            }

        }

    }

    
}
