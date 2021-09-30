using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaber_Playlist_Master_V2
{
    public class SongFile
    {
        public string _songName { set; get; }
        public string _levelAuthorName { set; get; }
        public string _songAuthorName { set; get; }
        public string _beatsPerMinute { set; get; }
        public string _coverImageFilename { set; get; }
        public string _environmentName { set; get; }
        public string _version { set; get; }

        public string key;
        //public _difficultyBeatmapSets _difficultyBeatmaps { set; get; }
        public _difficultyBeatmapSets[] _difficultyBeatmapSets { set; get; }

        public string[] difficulties;


        public string folderPath;

        public string filePath;

        
        //public string fullSongName;

        public DateTime lastModified;
    }
}
