using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Tweet
    {
        private static int CURRENT_ID;

        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from,string to, string body, string tag, string id)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = id;
        }

        public override string ToString()
        {
            if (this.Body.Length > 40)
            {
                return $"Tweet ID:{this.Id}\n" +
                    $"From:{this.From}\n" +
                    $"\"{this.Body.Remove(40)}\"\n" +
                    $"To:{this.To}\n" +
                    $"Tag:{this.Tag}\n";
            }
            return $"Tweet ID:{ this.Id}\n" +
                $"From:{this.From}\n" +
                $"\"{this.Body}\"\n" +
                $"To:{this.To}\n" +
                $"Tag:{this.Tag}\n";
        }
        public static Tweet Parse(string line)
        {
            string[] splitstring = line.Split(new char[] { '\t' });
            return new Tweet(splitstring[1], splitstring[2], splitstring[3], splitstring[0], splitstring[4]);
        }
    }
}
