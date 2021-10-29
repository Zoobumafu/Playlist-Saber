using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using WMPLib;
using System.Reflection;
using System.IO;
using System.Media;
using NAudio.Wave;


namespace BeatSaber_Playlist_Master_V2
{
    internal class PreviewPlayer
    {
        SoundPlayer Player;
        //static WMPLib.WindowsMediaPlayer Player;
        static int playCount = 0;

        public PreviewPlayer(PlaylistSong song)
        {
            Player = new SoundPlayer();
            //Player = new WMPLib.WindowsMediaPlayer();
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
                    string mp3FilePath = Path.GetTempPath() + @"PlaylistSaberMusicFile" + playCount + ".mp3";
                    File.WriteAllBytes(mp3FilePath, musicFile);
                    string wavFilePath = Path.GetTempPath() + @"PlaylistSaberMusicFile" + playCount + ".wav";
                    await ConvertMp3ToWav(mp3FilePath, wavFilePath);
                    Player.SoundLocation = wavFilePath;
                    playCount++;
                    Player.Play();
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


    private async Task ConvertMp3ToWav(string _inPath_, string _outPath_)
    {
        using (Mp3FileReader mp3 = new Mp3FileReader(_inPath_))
        {
            using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
            {
                WaveFileWriter.CreateWaveFile(_outPath_, pcm);
            }
        }
    }


}

    
}
