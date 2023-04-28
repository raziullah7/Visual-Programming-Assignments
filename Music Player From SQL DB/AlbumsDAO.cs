using MySql.Data.MySqlClient;
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
        //    // version 1 only contains fake data
        //// no connection to actual db
        //public List<Album> albums = new();


            // version 2 for real data
        // defining connection string and setting
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";
        // making method to get all lists
        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnThese = new List<Album>();

            // connect to mySQL database
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection to SQL server
            connection.Open();
            // writing query to be run
            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS", connection);
            // getting the data using MySqlDataReader
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(album);
                }
            }
            // closing connection to SQL server
            connection.Close();

            // returung the obtained list from the db
            return returnThese;
        }
    }
}
