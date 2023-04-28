using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_From_SQL_DB
{
    // DAO stands for Data Access Object
    internal class AlbumsDAO
    {
        // version 1 only contains fake data
        // no connection to actual db
        public List<Album> albums = new();
    }
}
