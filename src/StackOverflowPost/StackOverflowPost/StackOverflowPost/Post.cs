using System;

namespace StackOverflowPost
{
    class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime PostTime { get; private set; }
        public int Vote { get; private set; }


        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            PostTime = DateTime.Now;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }
    }
}
