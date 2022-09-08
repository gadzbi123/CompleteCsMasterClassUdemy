using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        public string WhoSend { get; set; }
        protected bool IsPublic { get; set; }

        public Post(string title, bool isPublic, string whoSend)
        {
            ID = GetNextId();
            Title = title;
            WhoSend = whoSend;
            IsPublic = isPublic;
        }
        public Post()
        {
            ID = 0;
            Title = "First Post";
            WhoSend = "Kacper";
            IsPublic = true;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", ID, Title, WhoSend);
        }
    }
}
