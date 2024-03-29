﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;

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
            SqlCommand cmd = new SqlCommand
            {
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
            string query = "INSERT INTO fake_albums (ALBUM_ID, ALBUM_NAME, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION) VALUES (@albumID, @albumName, @artistName, @year, @imageURL, @description)";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@albumID", getNextAlbumID());
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


        public int addOneTrack(Track track)
        {
            // creating sql connection
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            //string query = "INSERT INTO `albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @description)";
            // using a copy of albums table for testing
            string query = "INSERT INTO fake_tracks (TRACK_ID, TRACK_TITLE, TRACK_NUMBER, VIDEO_URL, TRACK_LYRICS, ALBUM_ID) VALUES (@trackID, @trackName, @trackNumber, @videoUrl, @trackLyrics, @albumId)";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@trackID", getNextTrackID());
            command.Parameters.AddWithValue("@trackName", track.TrackName);
            command.Parameters.AddWithValue("@trackNumber", track.TrackNumber);
            command.Parameters.AddWithValue("@videoUrl", track.VideoURL);
            command.Parameters.AddWithValue("@trackLyrics", track.TrackLyrics);
            command.Parameters.AddWithValue("@albumId", track.AlbumID);

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
            string query = "UPDATE fake_albums SET ALBUM_NAME = @albumName, ARTIST = @artistName, YEAR = @year, IMAGE_NAME = @imageURL, DESCRIPTION = @description WHERE ALBUM_ID = @albumId";

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


        public int updateOneTrack(Track track)
        {
            // creating sql connection
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            //string query = "INSERT INTO `albums` (`ALBUM_NAME`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumName, @artistName, @year, @imageURL, @description)";
            // using a copy of albums table for testing
            string query = "UPDATE fake_tracks SET TRACK_TITLE = @trackName, TRACK_NUMBER = @trackNumber, VIDEO_URL = @videoUrl, TRACK_LYRICS = @trackLyrics, ALBUM_ID = @albumId WHERE TRACK_ID = @trackID";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@trackID", track.TrackID);
            command.Parameters.AddWithValue("@trackName", track.TrackName);
            command.Parameters.AddWithValue("@trackNumber", track.TrackNumber);
            command.Parameters.AddWithValue("@videoUrl", track.VideoURL);
            command.Parameters.AddWithValue("@trackLyrics", track.TrackLyrics);
            command.Parameters.AddWithValue("@albumId", track.AlbumID);

            // executing the command
            int alteredRows = command.ExecuteNonQuery();

            // closing connection
            connection.Close();

            // returning the result
            return alteredRows;
        }


        public int deleteOneAlbum(Album album)
        {
            // creating sql connection
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            // string query = "DELETE FROM `albums` WHERE `ALBUM_ID`=@albumId";

            string query = "DELETE FROM fake_albums WHERE ALBUM_ID = @albumId";

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


        public int deleteOneTrack(Track track)
        {
            // creating sql connection
            SqlConnection connection = new SqlConnection(connectionString);
            // opening connection
            connection.Open();

            // writing the query (original albums table)
            // string query = "DELETE FROM `albums` WHERE `ALBUM_ID`=@albumId";

            string query = "DELETE FROM fake_tracks WHERE TRACK_ID = @trackId";

            // creating sql command
            SqlCommand command = new SqlCommand(query, connection);

            // adjusting parameters AddWithValue("arbitraryName", realValue)
            command.Parameters.AddWithValue("@trackId", track.TrackID);

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
            SqlCommand command = new SqlCommand("SELECT * FROM FAKE_TRACKS WHERE album_ID = @albumid", connection);
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
                        TrackID = Convert.ToInt32(sqlDataReader["TRACK_ID"]),
                        TrackName = Convert.ToString(sqlDataReader["TRACK_TITLE"]),
                        TrackNumber = Convert.ToInt32(sqlDataReader["TRACK_NUMBER"]),
                        VideoURL = Convert.ToString(sqlDataReader["VIDEO_URL"]),
                        TrackLyrics = Convert.ToString(sqlDataReader["TRACK_LYRICS"])
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
            command.CommandText = "SELECT TRACK_ID, albums.ALBUM_NAME as ALBUM_TITLE, TRACK_TITLE, VIDEO_URL, TRACK_LYRICS FROM tracks JOIN albums ON tracks.albums_ID = albums.ALBUM_ID WHERE ALBUM_ID = @albumid";

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


        private int getNextAlbumID()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = "select MAX(album_id) + 1 AS new_id from fake_albums;",
                Connection = sqlConnection
            };

            int ID = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader["new_id"]);
            }
            return ID;
        }


        private int getNextTrackID()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT MAX(TRACK_ID) + 1 AS new_id FROM fake_tracks;",
                Connection = sqlConnection
            };

            int ID = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader["new_id"]);
            }
            return ID;
        }


        public void generateTracksExcelReport()
        {
            string currentdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"D:\Files\Logs";
            // string connectionString = @"Server=DESKTOP-EKJ1P64\SQL2019;Database=Test;Integrated Security=True;";
            string queryString = "select * from fake_tracks";
            string filePath = @"D:\Files\Excel Reports\Fake_Tracks.XLSX";

            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);

                // Connect to the SQL Server database and retrieve the data you want to export
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a new Excel application and workbook
                            Application excelApp = new Application();
                            Workbook excelWorkbook = excelApp.Workbooks.Add();
                            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                            // Add the headers to the first row
                            int col = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
                                col++;
                            }

                            // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                            int row = 2;
                            while (reader.Read())
                            {
                                col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    excelWorksheet.Cells[row, col].Value2 = reader[i];
                                    col++;
                                }
                                row++;
                            }

                            // Save the workbook and close the Excel application
                            excelWorkbook.SaveAs(filePath);
                            excelWorkbook.Close();
                            excelApp.Quit();
                        }
                    }
                }
            }

            catch (Exception exception)
            {
                using (StreamWriter sw = File.CreateText(LogFolder + "\\" + "ErrorLog_" + currentdatetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }

            }
        }


        public void generateAlbumsExcelReport()
        {
            string currentdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string LogFolder = @"D:\Files\Logs";
            // string connectionString = @"Server=DESKTOP-EKJ1P64\SQL2019;Database=Test;Integrated Security=True;";
            string queryString = "select * from fake_tracks";
            string filePath = @"D:\Files\Excel Reports\Fake_Albums.XLSX";

            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);

                // Connect to the SQL Server database and retrieve the data you want to export
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a new Excel application and workbook
                            Application excelApp = new Application();
                            Workbook excelWorkbook = excelApp.Workbooks.Add();
                            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                            // Add the headers to the first row
                            int col = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
                                col++;
                            }

                            // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                            int row = 2;
                            while (reader.Read())
                            {
                                col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    excelWorksheet.Cells[row, col].Value2 = reader[i];
                                    col++;
                                }
                                row++;
                            }

                            // Save the workbook and close the Excel application
                            excelWorkbook.SaveAs(filePath);
                            excelWorkbook.Close();
                            excelApp.Quit();
                        }
                    }
                }
            }

            catch (Exception exception)
            {
                using (StreamWriter sw = File.CreateText(LogFolder + "\\" + "ErrorLog_" + currentdatetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }

            }
        }


        public void generateTracksWordReport()
        {
            string query = "SELECT * FROM fake_tracks";
            System.Data.DataTable dataTable = new System.Data.DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                }
            }
            // storing the file storage path
            string fileName = "D:\\Files\\Word Reports\\Fake_Tracks.docx";
            // creating Word document
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("SQL Server Data Export"));

                // Iterate through the DataTable and add the data to the Word document
                foreach (DataRow row in dataTable.Rows)
                {
                    para = body.AppendChild(new Paragraph());
                    run = para.AppendChild(new Run());

                    // Iterate through the columns
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        run.AppendChild(new Text(row[i].ToString()));
                        run.AppendChild(new Break());
                    }
                }

                // Save and close the Word document
                wordDocument.Save();
            }
        }


        public void generateAlbumsWordReport()
        {
            string query = "SELECT * FROM fake_albums";
            System.Data.DataTable dataTable = new System.Data.DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                }
            }
            // storing the file storage path
            string fileName = "D:\\Files\\Word Reports\\Fake_Albums.docx";
            // creating Word document
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("SQL Server Data Export"));

                // Iterate through the DataTable and add the data to the Word document
                foreach (DataRow row in dataTable.Rows)
                {
                    para = body.AppendChild(new Paragraph());
                    run = para.AppendChild(new Run());

                    // Iterate through the columns
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        run.AppendChild(new Text(row[i].ToString()));
                        run.AppendChild(new Break());
                    }
                }

                // Save and close the Word document
                wordDocument.Save();
            }
        }


        public void generateTracksPdfReport()
        {
            // SQL query to retrieve data
            string query = "SELECT * FROM fake_tracks";

            // Create a SqlConnection and SqlCommand to execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Execute the query and retrieve the data into a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Create a new PDF document
                        iTextSharp.text.Document document = new iTextSharp.text.Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("D:\\Files\\PDF Reports\\Fake_Tracks.pdf", FileMode.Create));
                        document.Open();

                        // Create a PdfPTable to hold the data
                        PdfPTable table = new PdfPTable(reader.FieldCount);

                        // Add table headers
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.AddCell(reader.GetName(i));
                        }

                        // Add table rows
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                table.AddCell(reader[i].ToString());
                            }
                        }

                        // Add the table to the document
                        document.Add(table);

                        // Close the document
                        document.Close();
                    }
                }
            }
        }


        public void generateAlbumsPdfReport()
        {
            // SQL query to retrieve data
            string query = "SELECT * FROM fake_albums";

            // Create a SqlConnection and SqlCommand to execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Execute the query and retrieve the data into a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Create a new PDF document
                        iTextSharp.text.Document document = new iTextSharp.text.Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("D:\\Files\\PDF Reports\\Fake_Albums.pdf", FileMode.Create));
                        document.Open();

                        // Create a PdfPTable to hold the data
                        PdfPTable table = new PdfPTable(reader.FieldCount);

                        // Add table headers
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.AddCell(reader.GetName(i));
                        }

                        // Add table rows
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                table.AddCell(reader[i].ToString());
                            }
                        }

                        // Add the table to the document
                        document.Add(table);

                        // Close the document
                        document.Close();
                    }
                }
            }
        }
    }
}
