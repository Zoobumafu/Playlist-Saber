using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeatSaverSharp;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BeatSaber_Playlist_Master_V2
{
    internal class Downloader
    {
        public static BeatSaver beatSaver;

        private static List<PlaylistSong> downloadQueue = new List<PlaylistSong>();
         //HttpOptions options;
        static Task downloadTask;
        bool running;
        bool firstRun;
        public string downloadFeedbackMessage;

        public Downloader()
        {
            //options = new HttpOptions(Data.appName, Data.version);
            BeatSaverOptions options = new BeatSaverOptions(Data.appName, Data.version);
            beatSaver = new BeatSaver(options);
            downloadTask = new Task(runQueue);
            running = false;
            firstRun = true;
            downloadFeedbackMessage = "";
        }


        public  bool isInQueue(PlaylistSong song)
        {
            if (downloadQueue.Contains(song))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  bool addSongToQueue(PlaylistSong song)
        {
            if (!isInQueue(song))
            {
                downloadQueue.Add(song);

                if (!running)
                {
                    if (!firstRun)
                    {
                        downloadTask.Dispose();
                        downloadTask = new Task(runQueue);
                    }
                    downloadTask.Start();
                    firstRun = false;
                }

                /*if (downloadTask.Status == TaskStatus.RanToCompletion)
                {
                    downloadTask.Dispose();
                    downloadTask = new Task(runQueue);
                    downloadTask.Start();
                }
                else if (!running)
                {
                    downloadTask.Start();
                }*/
                return true;
            }
            else
            {
                return false;
            }
        }

        private async  Task downloadSong(PlaylistSong song)
        {
            // Fetching song details + aborting download if failing.
            var myMap = await beatSaver.BeatmapByHash(song.hash);
            if (myMap == null)
            {
                Console.WriteLine("Error fetching metadata of " + song.songName);
                MessageBox.Show("Error fetching metadata of " + song.songName);
                downloadFeedbackMessage = "Error fetching metadata of " + song.songName + " song download aborted...";
                return;
            }

            // Downloading zip of the map.
            await myMap.LatestVersion.DownloadZIP();

            System.Byte[] file = myMap.LatestVersion.DownloadZIP().Result;

            if (file == null)
            {
                Console.WriteLine("Error downloading " + song.songName);
                MessageBox.Show("Error downloading " + song.songName);
                downloadFeedbackMessage ="Error downloading " + song.songName + " song download aborted...";
                return;
            }

            // Saving the Zip to Windows temporary directory
            File.WriteAllBytes(Path.GetTempPath() + myMap.Metadata.SongName + @".zip", file);

            // Setting variables to fetch the zip and save the song files
            string newPath = Data.installPath + @"\Beat Saber_Data\CustomLevels\" + myMap.Metadata.SongName;
            string tempPath = Path.GetTempPath() + myMap.Metadata.SongName + @".zip";

            // Reading and extracting directory
            System.IO.Compression.ZipArchive zip = ZipFile.OpenRead(tempPath);
            if (Directory.Exists(@newPath))
            {
                Directory.Delete(@newPath, true);
            }
            try
            {
                zip.ExtractToDirectory(@newPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error extracting " + song.songName + "\n" + e.Message);
                MessageBox.Show("Error extracting " + song.songName);
                downloadFeedbackMessage = "Error extracting " + song.songName + " song download aborted...";
                return;
            }
            zip.Dispose();

            try
            {
                File.Delete(@tempPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting zip " + song.songName + "\nSong has likely been downloaded with no issues\n" + e.Message);
            }

            // TO-DO replace the song file with this new file
            SongFile thisSongFile= new SongFile();
            string jsonString = File.ReadAllText(@newPath + @"\info.dat");   
            SongFile newSongFile = JsonConvert.DeserializeObject<SongFile>(jsonString);
            song.file = newSongFile;
            DirectoryInfo info = new DirectoryInfo(@newPath);
            song.filePath = info.FullName;
            song.file.folderPath = info.FullName;
            song.file.lastModified = info.LastWriteTime;
            Form1.CreateHash(song);
        }
        
        private async void runQueue()
        {
            running = true;
            while (downloadQueue.Count > 0)
            {
                await downloadSong(downloadQueue[0]);
                downloadQueue.RemoveAt(0);
            }
            running = false; 
        }


    }
}
