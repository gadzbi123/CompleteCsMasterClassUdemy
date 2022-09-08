using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheretence
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, string whoSend, string imageURL, bool isPublic) : base(title, isPublic, whoSend)
        {
            this.ID = GetNextId();
            ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {3} - by {2}", ID, Title, WhoSend, ImageURL);
        }

    }
}
