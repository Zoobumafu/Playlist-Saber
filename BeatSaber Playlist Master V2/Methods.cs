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
using System.Security.Cryptography;


namespace BeatSaber_Playlist_Master_V2
{
    public partial class Form1
    {
        // BeatsaverSharp parameters

        HttpOptions options;
        BeatSaver beatSaver;

        /// <summary>
        /// Detect and read all playlist files 
        /// </summary>
        void ReadPlaylist(List<Playlist> playlists)
        {
            if (!Directory.Exists(Data.installPath + @"\Playlists"))
            {
                Directory.CreateDirectory(Data.installPath + @"\Playlists");
            }
            DirectoryInfo playlistsDirectory = new DirectoryInfo(Data.installPath + @"\Playlists");
            var playlistFiles = playlistsDirectory.GetFiles();

            for (int i = 0; i < playlistFiles.Length; i++)
            {
                string tempString = System.IO.File.ReadAllText(playlistFiles[i].FullName);
                string myString = tempString.Substring(tempString.IndexOf('{'));
                playlists.Add(JsonConvert.DeserializeObject<Playlist>(myString));

                playlists[i].filePath = playlistFiles[i].FullName;

                //Save an image, if exists
                if (playlists[i].image != null)
                {
                    playlists[i].setImage();
                }

                //Recreate Hashes, incase they were not created properly the last time
                //foreach (PlaylistSong song in playlists[i].songs)
                //{
                //    song.hash = CreateHash(song.filePath);
                //}
            }
        }



        /// <summary>
        /// Detect location of installation directory
        /// </summary>
        public void FindBeatSaberDirectory()
        {
            //string previousDirectory = "";  TO DELETE AFTER TESTING
            //bool correctDirectory = false; TO DELETE AFTER TESTING

            // Check installation location by registry key
            var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            var myKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 620980");

            if (myKey != null)
            {
                string value = (string)(myKey.GetValue("InstallLocation"));
                if (File.Exists(@value + @"\Beat Saber.exe"))
                {
                    //correctDirectory = true; TO DELETE AFTER TESTING
                    Data.installPath = @value;
                }
            }

            else
            {
                MessageBox.Show("Could not find BeatSaber installation manually, can you please locate it?");
                bool located = false;
                while (!located)
                {
                    // If the registry key cannot be found, prompt the user to input details
                    FolderBrowserDialog dlg = new FolderBrowserDialog();
                    dlg.Description = "Locate BeatSaber directory";
                    dlg.ShowDialog();
                    if (File.Exists(dlg.SelectedPath + @"\Beatsaber.exe"))
                    {
                        located = true;
                    }
                    else
                    {
                        MessageBox.Show("Could not BeatSaber.exe in the selected path, please try again");
                        dlg.ShowDialog();
                    }
                }
            }
        }



        /// <summary>
        /// Get list of all songs by name and files
        /// </summary>
        void FindAllSongs(List<PlaylistSong> allSongs, List<Playlist> playlists)
        {
            //Get all song directories
            DirectoryInfo filesDirectory = new DirectoryInfo(Data.installPath + @"\Beat Saber_Data\CustomLevels");
            DirectoryInfo[] files = filesDirectory.GetDirectories();


            //Create songFile object from the files
            List<SongFile> songsInDirectory = new List<SongFile>();

            string paths = "";
            for (int i = 0; i < files.Length; i++)
            {
                string jsonString = File.ReadAllText(files[i].FullName + @"\info.dat");
                paths += files[i].FullName + @"\info.dat" + "\n";

                SongFile newSong = JsonConvert.DeserializeObject<SongFile>(jsonString);
                newSong.folderPath = files[i].FullName;
                newSong.lastModified = files[i].LastWriteTime;
                songsInDirectory.Add(newSong);

                //songsInDirectory.Add(JsonConvert.DeserializeObject<SongFile>(jsonString));
                //songsInDirectory[songsInDirectory.Count - 1].folderPath = files[i].FullName;
                //songsInDirectory[songsInDirectory.Count - 1].lastModified = files[i].LastWriteTime;

                //MessageBox.Show(songsInDirectory[songsInDirectory.Count - 1]._difficultyBeatmapSets[0]._difficultyBeatmaps[0]._difficulty);
            }

            //MessageBox.Show(paths);

            //Create a playlistSong object from songFile object
            for (int i = 0; i < songsInDirectory.Count; i++)
            {
                PlaylistSong newSong = new PlaylistSong();
                newSong.songName = songsInDirectory[i]._songName;
                newSong.uploader = songsInDirectory[i]._levelAuthorName;
                newSong.artist = songsInDirectory[i]._songAuthorName;
                newSong.filePath = songsInDirectory[i].folderPath;
                newSong.file = songsInDirectory[i];
                newSong.hash = CreateHash(newSong);
                //MessageBox.Show(newSong.songName + newSong.filePath +"\n" + newSong.hash);
                allSongs.Add(newSong);
            }
        }

        // Create hash for playlist songs, and than check if they already exist in AllSongs
        public void MergeSongs (List<PlaylistSong> myAllSongs, List<Playlist> myPlaylists)
        {
            for (int i = 0; i < myPlaylists.Count; i++)
            {
                for (int j = 0; j < myPlaylists[i].songs.Count; j++)
                {
                    if (myPlaylists[i].songs[j].filePath != null)
                    {
                        myPlaylists[i].songs[j].hash = CreateHash(myPlaylists[i].songs[j]);
                    }
                }
            }
            
            for (int i = 0; i < playlists.Count; i++)
            {
                for (int j = 0; j < playlists[i].songs.Count; j++)
                {
                    for (int k = 0; k < allSongs.Count; k++)
                    {
                        if (string.Equals(playlists[i].songs[j].hash, allSongs[k].hash, StringComparison.OrdinalIgnoreCase))
                        {
                            playlists[i].songs[j] = allSongs[k];
                        }
                            //if (playlists[i].songs[j].hash == allSongs[k].hash)
                        
                    }
                }
            }
        }


        /// <summary>
        /// Convert song into hash by path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string CreateHash(PlaylistSong thisSong)
        {
            if (thisSong.file != null)
            {
                List<string> fileNames = new List<string>();
                fileNames.Add("info.dat");
                for (int i = 0; i < thisSong.file._difficultyBeatmapSets.Length; i++)
                {
                    
                    //detect and add difficulties accordingly
                    if (thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps.Length != 0)
                    {
                        for (int j = 0; j < thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps.Length; j++)
                        {
                            if (File.Exists(thisSong.file.folderPath + @"\" + thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._difficulty + thisSong.file._difficultyBeatmapSets[i]._beatmapCharacteristicName + ".dat"))
                            {
                                fileNames.Add(thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._beatmapFilename);
                            }

                            // THIS IS THE OLD WAY, I FOUND A BETTER ONE (right above this line).

                            ////STANDARD
                            //if (thisSong.file._difficultyBeatmapSets[i]._beatmapCharacteristicName == "Standard")
                            //{
                            //    // Check if file exists with the addition of "Standard" to it's name
                            //    if (File.Exists(thisSong.file.folderPath + @"\" + thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._difficulty + thisSong.file._difficultyBeatmapSets[i]._beatmapCharacteristicName + ".dat"))
                            //    {
                            //        fileNames.Add(thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._difficulty + thisSong.file._difficultyBeatmapSets[i]._beatmapCharacteristicName);
                            //    }
                            //    // If not, add the song file without the difficulty name
                            //    else
                            //    {
                            //        fileNames.Add(thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._difficulty);
                            //    }
                            //}

                            ////ONE SABER
                            //if (thisSong.file._difficultyBeatmapSets[i]._beatmapCharacteristicName == "OneSaber")
                            //{
                            //    fileNames.Add(thisSong.file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._difficulty + thisSong.file._difficultyBeatmapSets[i]._beatmapCharacteristicName);
                            //}
                        }
                        //MessageBox.Show(String.Join("\n", fileNames));
                    }
                }

                thisSong.file.difficulties = fileNames.ToArray();

                //Detecting file existence and than converting file into byte[]
                byte[][] fileBytes = new byte[fileNames.Count][];

                for (int i = 0; i < fileNames.Count; i++)
                {
                    //Name of the difficulty or info file
                    string newFileName = thisSong.file.folderPath + @"\" + fileNames[i];
                    if (File.Exists(newFileName))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(newFileName);
                        fileBytes[i] = bytes;
                    }
                    else
                    {

                    }
                }

                //Combine all Bytes into one, first info.dat, than the difficulties, from the hardest to the easiest
                byte[] finalByte = { };
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] != null)
                    {
                        //MessageBox.Show(str = System.Text.Encoding.Default.GetString(fileBytes[i]));
                        finalByte = finalByte.Concat(fileBytes[i]).ToArray();
                    }
                }

                //Converting byte[] into SHA1

                var sha1 = SHA1.Create();
                byte[] hashBytes = sha1.ComputeHash(finalByte);
                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                return hash;
            }
            
            else if (thisSong.hash != null)
            {
                MessageBox.Show(thisSong.hash);
                return thisSong.hash;
                
            }
            else
            {
                return null;
            }

        }


        public void AssociatePlaylistsWithSong()
        {
            foreach (Playlist playlist in playlists)
            {
                playlist.gatherSongList(allSongs);
            }
        }


        public void AddSong(PlaylistSong song = null, Playlist playlist = null)
        {
            // Determine if we are adding the currently selected song, or a song received from sender as well as
            // determine if we are adding a song to current playlist, or to the one sent by sender.
            PlaylistSong currentSong;
            Playlist currentPlaylist;
            if (song == null)
            {
                currentSong = (PlaylistSong)allSongsTreeView.SelectedNode.Tag;
            }
            else
            {
                currentSong = song;
            }
            if (playlist == null)
            {
                if (playlistTreeView.SelectedNode == null)
                {
                    return;
                }
                currentPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;
            }
            else
            {
                currentPlaylist = playlist;
            }

            if (playlistTreeView.SelectedNode != null)
                {
                    // Add song to playlist
                    currentPlaylist.songs.Add(currentSong);

                    // Add song to UI
                    TreeNode node = new TreeNode();
                    node.Tag = currentSong;
                    node.Text = currentSong.songName;
                    songsInPlaylistTreeView.Nodes.Add(node);
                }
            

            // Don't know why this paragraph exists, but I am too scared to delete it

            //else
            //{
            //    Playlist currentPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;
            //    PlaylistSong currentSong = (PlaylistSong)allSongsTreeView.SelectedNode.Tag;
            //    currentPlaylist.songs.Add((PlaylistSong)allSongsTreeView.SelectedNode.Tag);
            //}
            
        }

        public void RemoveSong()
        {
            if (songsInPlaylistTreeView.SelectedNode != null)
            {
                Playlist currentPlaylist = (Playlist)playlistTreeView.SelectedNode.Tag;
                currentPlaylist.songs.Remove((PlaylistSong)songsInPlaylistTreeView.SelectedNode.Tag);
                songsInPlaylistTreeView.SelectedNode.Remove();
            }
        }

        void saveAll()
        {
            // NewtonSoft cant save image file properly, therefore it is deleted before saving
            
                for (int i = 0; i < playlists.Count; i++)
                {
                    //@"data:image/gif;base64," + Convert.ToBase64String(File.ReadAllBytes
                    //playlists[i].image = @"data:image/gif;base64," + Convert.ToBase64String(playlists[i].imageFile);
                    playlists[i].imageFile = null;
                    string jsonText = JsonConvert.SerializeObject(playlists[i], Formatting.Indented);
                    File.WriteAllText(playlists[i].filePath, jsonText);
                }
                MessageBox.Show("All playlists saved successfully");

            for (int i = 0; i < playlists.Count; i++)
            {
                playlists[i].setImage();
            }

        }

         void setImage()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp; *.jpg; *.jpeg,*.png)|*.BMP; *.JPG; *.JPEG; *.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                      selectedPlaylist.image = @"data:image/gif;base64," + Convert.ToBase64String(File.ReadAllBytes(@dlg.FileName));
                      selectedPlaylist.setImage();
                      playlistPictureBox.Image = selectedPlaylist.imageFile;
                }
            }
        }

        

        string[] GetDifficulties()
        {
            
            return null;
        }
    }

}