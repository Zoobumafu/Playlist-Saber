using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaber_Playlist_Master_V2
{
    /// <summary>
    /// Class for keeping count of general data
    /// </summary>
    class Data
    {
        public static string appName = "BeatSaber Playlist Master";
        public static Version version = new Version(1, 2, 0);

        public static int numberOfSongs = 0;
        public static int numberOfPlaylists = 0;

        public static string installPath = null;

        // Flag to track if there should be prompt to save the changes
        public static bool isSaved = true;

        // Flags to track if search mode filters

        
        public static bool standardMode = false; // Standard
        public static bool OneSaberMode = false; // OneSaber
        public static bool ninetyDegreesMode = false; // 90Degree
        public static bool threeSixtyDegreesMode = false; // 360Degree
        public static bool lightShowMode = false; // Lightshow
        public static bool noArrowsMode = false; // NoArrows
        public static bool otherMode = false; // 

        public static string[] modeNames = { "Standard", "OneSaber", "90Degree", "360Degree", "Lightshow", "NoArrows" };
           

    }


}
