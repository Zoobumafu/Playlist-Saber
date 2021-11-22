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
    // Struct for download queue items
    struct downloadQueueItem
    {
        public PlaylistSong song;
        public Playlist playlist;
    }

    public class Downloader
    {
        public static BeatSaver beatSaver;

        private static List<downloadQueueItem> downloadQueue = new List<downloadQueueItem>();
         //HttpOptions options;
        static Task downloadTask;
        bool running;
        bool firstRun;
        public string downloadFeedbackMessage;
        Form1 mainForm;

        public Downloader(Form1 callerForm)
        {
            //options = new HttpOptions(Data.appName, Data.version);
            BeatSaverOptions options = new BeatSaverOptions(Data.appName, Data.version);
            beatSaver = new BeatSaver(options);
            downloadTask = new Task(runQueue);
            running = false;
            firstRun = true;
            downloadFeedbackMessage = "";
            mainForm = callerForm;
        }


        public  bool isInQueue(PlaylistSong song)
        {
            for (int i = 0; i < downloadQueue.Count; i++)
            {
                if (downloadQueue[i].song.Equals(song))
                {
                    return true;
                }
            }
            
            return false;
        }


        /// <summary>
        /// Specify the song you want to download, and the playlist you want it to be added (default is null, which means it won't be added to any playlist)
        /// </summary>
        /// <param name="songToDownload"></param>
        /// <param name="playlist"></param>
        /// <returns></returns>
        public  bool addSongToQueue(PlaylistSong songToDownload, Playlist playlist = null)
        {
            songToDownload.name = validateName(songToDownload.name);
            if (!isInQueue(songToDownload))
            {
                downloadQueueItem newDownloadQueueItem = new downloadQueueItem();
                newDownloadQueueItem.song = songToDownload;
                newDownloadQueueItem.playlist = playlist;
                downloadQueue.Add(newDownloadQueueItem);
                
                if (!running)
                {
                    if (!firstRun)
                    {
                        try
                        {
                            downloadTask.Dispose();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error disposing download task" + e.Message);
                        }


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

        private async  Task downloadSong(downloadQueueItem songToDownload)
        {
            // Fetching song details + aborting download if failing.
            var myMap = await beatSaver.BeatmapByHash(songToDownload.song.hash);
            if (myMap == null)
            {
                Console.WriteLine("Error fetching metadata of " + songToDownload.song.name);
                MessageBox.Show("Error fetching metadata of " + songToDownload.song.name);
                downloadFeedbackMessage = "Error fetching metadata of " + songToDownload.song.name + " song download aborted...";
                return;
            }

            // Downloading zip of the map.
            await myMap.LatestVersion.DownloadZIP();

            System.Byte[] file = myMap.LatestVersion.DownloadZIP().Result;

            if (file == null)
            {
                Console.WriteLine("Error downloading " + songToDownload.song.name);
                MessageBox.Show("Error downloading " + songToDownload.song.name);
                downloadFeedbackMessage ="Error downloading " + songToDownload.song.name + " song download aborted...";
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
                Console.WriteLine("Error extracting " + songToDownload.song.name + "\n" + e.Message);
                MessageBox.Show("Error extracting " + songToDownload.song.name);
                downloadFeedbackMessage = "Error extracting " + songToDownload.song.name + " song download aborted...";
                return;
            }
            zip.Dispose();

            try
            {
                File.Delete(@tempPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting zip " + songToDownload.song.name + "\nSong has likely been downloaded with no issues\n" + e.Message);
            }

            SongFile thisSongFile= new SongFile();
            string jsonString = File.ReadAllText(@newPath + @"\info.dat");   
            SongFile newSongFile = JsonConvert.DeserializeObject<SongFile>(jsonString);
            songToDownload.song.file = newSongFile;
            DirectoryInfo info = new DirectoryInfo(@newPath);
            songToDownload.song.filePath = info.FullName;
            songToDownload.song.file.folderPath = info.FullName;
            songToDownload.song.file.lastModified = info.LastWriteTime;
            Form1.CreateHash(songToDownload.song);

            // Add song to the currect playlist and to all songs.
            if (!mainForm.allSongs.Contains(songToDownload.song))
            {
                mainForm.allSongs.Add(songToDownload.song);
            }
            if (songToDownload.playlist != null)
            {
                songToDownload.playlist.songs.Add(songToDownload.song);
            }


            
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

        private string validateName(string name)
        {
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            //^(.*?/|.*?\\)?([^\./|^\.\\]+)(?:\.([^\\]*)|)$
            string validName = name;
            if (name != null)
            {
                validName = new string(name.Where(Char.IsLetter).ToArray());
            }
            return validName;
        }


    }
}
