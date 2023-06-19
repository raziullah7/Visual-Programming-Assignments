using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
// using System.Data.SqlClient;

namespace Online_Music_Player_From_SQL_DB
{
    // DAO stands for Data Access Object
    internal class SqlAlbumsDAO
    {
        string connectionString = "data source=WARMACHINE\\SQLEXPRESS; database=MUSIC; integrated security=SSPI;";

        // making method to get all lists
        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnThese = new List<Album>();

            // connect to SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection to SQL server

            // writing sql query  
            SqlCommand cmd = new SqlCommand {
                CommandText = "SELECT ALBUM_ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM FAKE_ALBUMS",
                Connection = connection
            };

            // Opening Connection  
            connection.Open();

            // Executing the SQL query  
            using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
            {
                // Iterating Data  
                while (sqlDataReader.Read())
                {
                    Album album = new Album
                    {
                        ID = Convert.ToInt32(sqlDataReader["ALBUM_ID"]),
                        AlbumName = Convert.ToString(sqlDataReader["ALBUM_NAME"]),
                        ArtistName = Convert.ToString(sqlDataReader["ARTIST"]),
                        Year = Convert.ToInt32(sqlDataReader["YEAR"]),
                        ImageURL = Convert.ToString(sqlDataReader["IMAGE_NAME"]),
                        Description = Convert.ToString(sqlDataReader["DESCRIPTION"])
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
            SqlConnection connection = new SqlConnection(connectionString);
            // open sql connection
            connection.Open();

            // make query object and query the database
            SqlCommand command = new SqlCommand
            {
                // getting connection
                Connection = connection,
                // setting up query to protect from sql injections
                CommandText = "SELECT ALBUM_ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM FAKE_ALBUMS WHERE ALBUM_NAME like @searchTitle"
            };

            // making a variable to store items to be searched
            string searchable = "%" + title + "%";
            // replacing @searchTitle with the passed title
            command.Parameters.AddWithValue("@searchTitle", searchable);

            // we have run the sql query and recieved an object
            // reading data from the object using MySqlDataReader
            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    // getting response album by album
                    Album album = new Album
                    {
                        ID = Convert.ToInt32(sqlDataReader["ALBUM_ID"]),
                        AlbumName = Convert.ToString(sqlDataReader["ALBUM_NAME"]),
                        ArtistName = Convert.ToString(sqlDataReader["ARTIST"]),
                        Year = Convert.ToInt32(sqlDataReader["YEAR"]),
                        ImageURL = Convert.ToString(sqlDataReader["IMAGE_NAME"]),
                        Description = Convert.ToString(sqlDataReader["DESCRIPTION"])
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
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            //string query = "INSERT INTO `albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @description)";
            // using a copy of albums table for testing
            string query = "INSERT INTO `fake_albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @description)";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

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
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            // string query = "UPDATE `albums` SET `ALBUM_NAME` = @albumName, `ARTIST` = @artistName, `YEAR` = @year, `IMAGE_NAME` = @imageURL, `DESCRIPTION` = @description";
            string query = "UPDATE `fake_albums` SET `ALBUM_NAME`=@albumName, `ARTIST`=@artistName,`YEAR`=@year,`IMAGE_NAME`=@imageURL,`DESCRIPTION`=@description WHERE `ALBUM_ID`=@albumId";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

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
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            // string query = "DELETE FROM `albums` WHERE `ALBUM_ID`=@albumId";

            string query = "DELETE FROM `fake_albums` WHERE `ALBUM_ID`=@albumId";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

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
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection before making sqlCommand
            connection.Open();

            // making sqlCommand
            SqlCommand command = new SqlCommand("SELECT * FROM TRACKS WHERE album_ID = @albumid", connection);
            // adding query to sqlCommand
            // command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";

            // @albumid is the parameter mentioned in the query
            // we have to define that parameter, which we get from
            // the parameter passed into the method
            command.Parameters.AddWithValue("@albumid", albumID);
            // giving the address of the mysqlconnection to mysqlcommand
            // command.Connection = connection;

            // executing command and reading the result
            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    // getting data track by track
                    Track track = new Track
                    {
                        ID = Convert.ToInt32(sqlDataReader["TRACK_ID"]),
                        Name = Convert.ToString(sqlDataReader["TRACK_TITLE"]),
                        Number = Convert.ToInt32(sqlDataReader["TRACK_NUMBER"]),
                        VideoURL = Convert.ToString(sqlDataReader["VIDEO_URL"]),
                        Lyrics = Convert.ToString(sqlDataReader["TRACK_LYRICS"])
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
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection before making sqlCommand
            connection.Open();

            // making sqlCommand
            SqlCommand command = new SqlCommand();
            // adding query to sqlCommand
            command.CommandText = "SELECT TRACK_ID, albums.ALBUM_NAME as 'ALBUM_TITLE', `TRACK_TITLE`, `VIDEO_URL`, `TRACK_LYRICS` FROM `tracks` JOIN albums ON tracks.albums_ID = albums.ALBUM_ID WHERE ALBUM_ID = @albumid";

            // @albumid is the parameter mentioned in the query
            // we have to define that parameter, which we get from
            // the parameter passed into the method
            command.Parameters.AddWithValue("@albumid", albumID);
            // giving the address of the mysqlconnection to mysqlcommand
            command.Connection = connection;

            // executing command and reading the result
            using (SqlDataReader reader = command.ExecuteReader())
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
