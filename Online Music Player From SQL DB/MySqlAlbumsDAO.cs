using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Music_Player_From_SQL_DB
{
    internal class MySqlAlbumsDAO
    {
        string connectionString = "server=localhost; port=3306; username=root; password=root; database=music;";

        // making method to get all lists
        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnThese = new List<Album>();

            // connect to mySQL database
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection to MYSQL server
            connection.Open();

            // writing query to be run
            // MySqlCommand command = new MySqlCommand("SELECT ALBUM_ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS", connection); // original table
            MySqlCommand command = new MySqlCommand("SELECT ALBUM_ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM FAKE_ALBUMS", connection); // test table

            
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
                    // adding all tracks to "list<track> Tracks"
                    album.Tracks = getTracksForAlbum(album.ID);
                    // adding tracks to temporary list
                    returnThese.Add(album);
                }
            }
            // closing connection to MYSQL server
            connection.Close();

            // returung the obtained list from the db
            return returnThese;
        }


        public List<Album> searchTitles(string title)
        {
            // start with an empty list
            List<Album> searchedAlbums = new List<Album>();

            // make sql connection object
            MySqlConnection connection = new MySqlConnection(connectionString);
            // open sql connection
            connection.Open();
            // make query object and query the database
            MySqlCommand command = new MySqlCommand();

            // setting up query to protect from sql injections
            command.CommandText = "SELECT ALBUM_ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS WHERE ALBUM_NAME like @searchTitle";
            // making a variable to store items to be searched
            string searchable = "%" + title + "%";

            // replacing @searchTitle with the passed title
            command.Parameters.AddWithValue("@searchTitle", searchable);
            // making sql db connection with the sql command
            command.Connection = connection;

            // we have run the sql query and recieved an object
            // reading data from the object using MySqlDataReader
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // getting response album by album
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    searchedAlbums.Add(album);
                }
            }
            // closing sql server connection
            connection.Close();
            // returning results
            return searchedAlbums;
        }


        public int addOneAlbum(Album album)
        {
            // creating sql connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            //string query = "INSERT INTO `albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @description)";
            // using a copy of albums table for testing
            string query = "INSERT INTO `fake_albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @description)";

            // creating sql command
            MySqlCommand command = new MySqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@albumName", album.AlbumName);
            command.Parameters.AddWithValue("@artistName", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            // executing the command
            int newRows = command.ExecuteNonQuery();

            // closing connection
            connection.Close();

            // returning the result
            return newRows;
        }


        public int updateOneAlbum(Album album)
        {
            // creating sql connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            // string query = "UPDATE `albums` SET `ALBUM_NAME` = @albumName, `ARTIST` = @artistName, `YEAR` = @year, `IMAGE_NAME` = @imageURL, `DESCRIPTION` = @description";
            string query = "UPDATE `fake_albums` SET `ALBUM_NAME`=@albumName, `ARTIST`=@artistName,`YEAR`=@year,`IMAGE_NAME`=@imageURL,`DESCRIPTION`=@description WHERE `ALBUM_ID`=@albumId";

            // creating sql command
            MySqlCommand command = new MySqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@albumId", album.ID);
            command.Parameters.AddWithValue("@albumName", album.AlbumName);
            command.Parameters.AddWithValue("@artistName", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            // executing the command
            int updatedRows = command.ExecuteNonQuery();

            // closing connection
            connection.Close();

            // returning the result
            return updatedRows;
        }


        public int deleteOneAlbum(Album album)
        {
            // creating sql connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            // string query = "DELETE FROM `albums` WHERE `ALBUM_ID`=@albumId";

            string query = "DELETE FROM `fake_albums` WHERE `ALBUM_ID`=@albumId";

            // creating sql command
            MySqlCommand command = new MySqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@albumId", album.ID);

            // executing the command
            int deletedRows = command.ExecuteNonQuery();

            // closing connection
            connection.Close();

            // returning the result
            return deletedRows;
        }


        public List<Track> getTracksForAlbum(int albumID)
        {
            // empty list of tracks
            List<Track> returnThese = new List<Track>();
            // creating connection with server
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection before making sqlCommand
            connection.Open();

            // making sqlCommand
            MySqlCommand command = new MySqlCommand();
            // adding query to sqlCommand
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";

            // @albumid is the parameter mentioned in the query
            // we have to define that parameter, which we get from
            // the parameter passed into the method
            command.Parameters.AddWithValue("@albumid", albumID);
            // giving the address of the mysqlconnection to mysqlcommand
            command.Connection = connection;

            // executing command and reading the result
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // getting data track by track
                    Track track = new Track
                    {
                        TrackID = reader.GetInt32(0),
                        TrackName = reader.GetString(1),
                        TrackNumber = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        TrackLyrics = reader.GetString(4)
                    };
                    returnThese.Add(track);
                }
            }
            // closing connection
            connection.Close();

            // returning list of tracks
            return returnThese;
        }


        public List<JObject> getTracksUsingJoins(int albumID)
        {
            // empty list of tracks
            List<JObject> returnThese = new List<JObject>();
            // creating connection with server
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection before making sqlCommand
            connection.Open();

            // making sqlCommand
            MySqlCommand command = new MySqlCommand();
            // adding query to sqlCommand
            command.CommandText = "SELECT TRACK_ID, albums.ALBUM_NAME as 'ALBUM_TITLE', `TRACK_TITLE`, `VIDEO_URL`, `TRACK_LYRICS` FROM `tracks` JOIN albums ON tracks.albums_ID = albums.ALBUM_ID WHERE ALBUM_ID = @albumid";

            // @albumid is the parameter mentioned in the query
            // we have to define that parameter, which we get from
            // the parameter passed into the method
            command.Parameters.AddWithValue("@albumid", albumID);
            // giving the address of the mysqlconnection to mysqlcommand
            command.Connection = connection;

            // executing command and reading the result
            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    // getting data track my track
                    JObject track = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        track.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    returnThese.Add(track);
                }
            }
            // closing connection
            connection.Close();

            // returning list of tracks
            return returnThese;
        }
    }
}
