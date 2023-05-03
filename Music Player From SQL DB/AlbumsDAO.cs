﻿using MySql.Data.MySqlClient;
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
            command.CommandText = "SELECT ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS WHERE ALBUM_NAME like @searchTitle";
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


        internal int addOneAlbum(Album album)
        {
            // creating sql connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query
            string query = "INSERT INTO `albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @Description)";

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
    }
}
