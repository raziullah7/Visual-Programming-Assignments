

// writing using StreamWriter class
try
{
    StreamWriter writer = new StreamWriter("C:\\Users\\DELL\\Downloads\\OneDrive\\Desktop\\FileHandling.txt");
    writer.Write("\nIT WORKSSS!!");
    writer.Write("\nOR DOES IT?");
    writer.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception" + e.Message);
    // Console.WriteLine(e.ToString());
}


// reading using StreamReader class
try
{
    StreamReader reader = new StreamReader("C:\\Users\\DELL\\Downloads\\OneDrive\\Desktop\\FileHandling.txt");

    Console.WriteLine(reader.ReadToEnd());

    //string line = "";
    //while (line != null)
    //{
    //    line = reader.ReadLine();
    //    Console.WriteLine(line);
    //}

    reader.Close();
}
catch(Exception e)
{
    Console.WriteLine("Exception" + e.Message);
    // Console.WriteLine(e.ToString());
}