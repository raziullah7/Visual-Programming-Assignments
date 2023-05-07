using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_From_SQL_DB
{
    internal class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string VideoURL { get; set; }
        public string Lyrics { get; set; }
    }
}
