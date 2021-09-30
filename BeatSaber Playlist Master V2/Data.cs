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
        public static Version version = new Version(1,2,0);

        public static int numberOfSongs = 0;
        public static int numberOfPlaylists = 0;

        public static string installPath = null;

        // Flag to track if there should be prompt to save the changes
        public static bool isSaved = false;
    }
}
