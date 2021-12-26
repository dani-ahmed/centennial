using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            TweetManager.Initialize();
            TweetManager.ShowAll();
            TweetManager.ShowAll("Raptors");

        }
    }
}
