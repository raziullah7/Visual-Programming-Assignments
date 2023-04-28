using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_From_SQL_DB
{
    internal class Album
    {
        public int ID { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        // coming soon is a list of List<Track>
    }
}
