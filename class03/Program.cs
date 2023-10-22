using System;

namespace class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timePerNews = new TimeSpan(0, 15, 35);

            
            int numberOfNews = int.Parse(Console.ReadLine());

            
            TimeSpan totalTime = timePerNews * numberOfNews;

           
            int hours = totalTime.Hours;
            int minutes = totalTime.Minutes;
            int seconds = totalTime.Seconds;

            Console.WriteLine($"寫{numberOfNews}篇新聞總共需要{hours}小時{minutes}分{seconds}秒");
        }
    }
}