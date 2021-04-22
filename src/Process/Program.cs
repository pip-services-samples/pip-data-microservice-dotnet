using Beacons.Containers;
using System;

namespace Process
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var process = new BeaconsProcess();
                process.RunAsync(args).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
