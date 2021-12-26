using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment2
{
    class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME;

        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            TextReader reader = new StreamReader("Assignment_02_TweetFile.txt");
            string line ="";
            while(line != null)
            {
                line = reader.ReadLine();
                Tweet tweet = Tweet.Parse(line);
                TWEETS.Add(tweet);
            }

        }

        public static void Initialize()
        {
            Tweet t1 = new Tweet("testFrom", "testTo", "testBody", "testTag", "testId1");
            TWEETS.Add(t1);
            Tweet t2 = new Tweet("testFrom", "testTo", "testBody", "testTag", "testId2");
            TWEETS.Add(t2);
            Tweet t3 = new Tweet("testFrom", "testTo", "testBody", "testTag", "testId3");
            TWEETS.Add(t3);
            Tweet t4 = new Tweet("testFrom", "testTo", "testBody", "testTag", "testId4");
            TWEETS.Add(t4);
            Tweet t5 = new Tweet("testFrom", "testTo", "testBody", "testTag", "testId5");
            TWEETS.Add(t5);
        }
        public static void ShowAll()
        {
            foreach (Tweet t in TWEETS)
            {
                Console.WriteLine(t.ToString());
            }
        }
        public static void ShowAll(string tag)

        {
            tag = tag.ToLower();
            foreach (Tweet t in TWEETS)
            {
                string temp = t.Tag;             

                if (temp == tag)
                {
                    Console.WriteLine(t.ToString());
                }
            }
        }
    }
}
