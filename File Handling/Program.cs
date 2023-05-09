

//// writing using StreamWriter class
//try
//{
//    StreamWriter writer = new StreamWriter("C:\\Users\\DELL\\Downloads\\OneDrive\\Desktop\\FileHandling.txt");
//    writer.Write("\nIT WORKSSS!!");
//    writer.Write("\nOR DOES IT?");
//    writer.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception" + e.Message);
//    // Console.WriteLine(e.ToString());
//}


//// reading using StreamReader class
//try
//{
//    StreamReader reader = new StreamReader("C:\\Users\\DELL\\Downloads\\OneDrive\\Desktop\\FileHandling.txt");

//    Console.WriteLine(reader.ReadToEnd());

//    //string line = "";
//    //while (line != null)
//    //{
//    //    line = reader.ReadLine();
//    //    Console.WriteLine(line);
//    //}

//    reader.Close();
//}
//catch(Exception e)
//{
//    Console.WriteLine("Exception" + e.Message);
//    // Console.WriteLine(e.ToString());
//}


// using FileStream
string path = ("C:\\Users\\DELL\\Downloads\\OneDrive\\Desktop\\Files\\FileHandling2.txt");
try
{
    // for previously existing file
    FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);

    // passing filestream in streamwriter
    StreamWriter writer = new StreamWriter(fileStream);
    // writer.WriteLine("This is the resistance");
    // writer.WriteLine("You can't resist us");

    // passing streamreader in filestream
    StreamReader reader = new StreamReader(fileStream);
    // printing to console
    Console.WriteLine(reader.ReadToEnd());

    //// iterating manually
    //string line = "";
    //while (line != null)
    //{
    //    line = reader.ReadLine();
    //    Console.WriteLine(line);
    //}

    // closing streams
    writer.Close();
    reader.Close();
    fileStream.Close();

}catch(Exception e)
{
    Console.WriteLine("Exception" + e.Message);
}