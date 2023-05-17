
class Program
{
    // equal number of sleep time assign 1st cycle to TempA
    // 2nd cycle to TempB and so on (alternately)
    public static void TempA()
    {
        for (int i = 1; i < 5; i++)
        {
            // makes the thread inactive for 500 milli-seconds
            Thread.Sleep( 500 );
            Console.WriteLine($"** Executing TempA {i} Time");
        }
    }

    public static void TempB()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine($"=> Executing TempB {i} Time");
            Thread.Sleep(500);
            // Thread.Abort();
            
        }
    }

    static void Main(string[] args)
    {
        // the thread is in unstarted state
        // thread is associated with Program.TempA
        Thread thread = new Thread(Program.TempA);
        // starting the thread
        thread.Start();

        // the thread is in unstarted state
        // thread is associated with Program.TempB
        Thread thread2 = new Thread(Program.TempB);
        // starting the thread2
        thread2.Start();

    }
}