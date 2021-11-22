using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BeatSaber_Playlist_Master_V2
{
    public class PlaylistSong
    {
        public string key { set; get; }
        public string uploader { set; get; }
        public string hash { set; get; }
        public string name { set; get; }
        public int _beatsPerMinute { set; get; }
        public string artist { set; get; }
        public string filePath;
        public Image image {  set; get; }
        public string difficultiesFromBeatSaver {  set; get; }
        public int length {  set; get; }


        public string downloadURL;



        //string mapName;

        public SongFile file;

        public string GetDifficultiesString()
        {
            if (file != null)
            {
                string difficultiesString = "";
                for (int i = 0; i < file._difficultyBeatmapSets.Length; i++)
                {
                    difficultiesString += file._difficultyBeatmapSets[i]._beatmapCharacteristicName + ": ";
                    difficultiesString += file._difficultyBeatmapSets[i]._difficultyBeatmaps[0]._difficulty + "\n";
                    for (int j = 1; j < file._difficultyBeatmapSets[i]._difficultyBeatmaps.Length; j++)
                    {
                        for (int k = 0; k < file._difficultyBeatmapSets[i]._beatmapCharacteristicName.Length + 10; k++)
                        {
                            difficultiesString += " ";
                        }
                        difficultiesString += file._difficultyBeatmapSets[i]._difficultyBeatmaps[j]._difficulty + "\n";
                    }
                }

                return difficultiesString;
            }

            else return "";
        }

        // Return the song's image
        public Image getSongImage()
        {
            Bitmap bitmap = null;
            if (file != null)
            {
                if (file._coverImageFilename != null)
                {
                    //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(allSongs[i].file.filePath + @"\" + allSongs[i].file._coverImageFilename);
                    try
                    {
                        bitmap = new System.Drawing.Bitmap(file.folderPath + @"\" + file._coverImageFilename);
                        //songPictureBox.Image = bitmap;
                    }
                    catch (Exception e)
                    {
                        bitmap = null;
                        Console.WriteLine("Error finding image in " + name + "\n" + e.Message);
                    }
                }
            }
            return bitmap;
        }

    }
}
