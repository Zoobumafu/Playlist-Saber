using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaber_Playlist_Master_V2
{
    // Support class to read diffulties of a level
    public class _difficultyBeatmaps
    {
        public string _difficulty { set; get; }
        public string _beatmapFilename { set; get; }
        public string _noteJumpMovementSpeed { set; get; }
        public string _noteJumpStartBeatOffset { set; get; }

    }
}
