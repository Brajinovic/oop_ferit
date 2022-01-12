using System;
using System.Collections.Generic;
using System.Text;

namespace labosi6
{
    class Post
    {
        private string accountName;
        private string message;
        private List<string> hashtags = new List<string>();
        private DateTime time;

        public Post(string accountName, string message, List<string> hashtags)
        {
            this.accountName = accountName;
            this.message = message;
            this.hashtags.AddRange(hashtags);
            time = DateTime.Now;
        }

        public Post(Post parent)
        {
            this.accountName = parent.AccountName;
            this.message = parent.Message;
            this.hashtags.AddRange(parent.Hashtags);
            this.time = parent.Time;
        }

        public string AccountName
        {
            get { return this.accountName; }
        }

        public string Message
        {
            get { return this.message; }
        }
        public DateTime Time
        {
            get { return this.time; }
        }
        public List<string> Hashtags
        {
            get { return this.hashtags; }
        }

        public void Tag(string hashtag)
        {
            this.hashtags.Add(hashtag);
        }

        public void Untag(string hashtag)
        {
            this.hashtags.Remove(hashtag);
        }

        public override string ToString()
        {
            return $"Account name: {AccountName}\nMessage: {Message}\nTime of publishment: {Time}\nTags: {Hashtags.Count}\n\n";
        }
    }
}
