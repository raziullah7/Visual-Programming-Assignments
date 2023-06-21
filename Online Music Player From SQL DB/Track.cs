using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Music_Player_From_SQL_DB
{
    internal class Track
    {
        public int TrackID { get; set; }
        public string TrackName { get; set; }
        public int TrackNumber { get; set; }
        public string VideoURL { get; set; }
        public string TrackLyrics { get; set; }
        public int AlbumID { get; set; }
    }
}
