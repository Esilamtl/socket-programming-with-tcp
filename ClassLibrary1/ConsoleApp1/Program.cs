using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessClass logger = new BusinessClass(1000);
            logger.Start();
            Console.WriteLine("durdurmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
            logger.Stop();
        }
    }
}
