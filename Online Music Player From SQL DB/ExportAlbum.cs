using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Music_Player_From_SQL_DB
{
    // made this class for exporting albums from the main form
    // to update form (one album at a time)
    internal static class ExportAlbum
    {
        public static Album exportAlbum { get; set; }
    }
}
