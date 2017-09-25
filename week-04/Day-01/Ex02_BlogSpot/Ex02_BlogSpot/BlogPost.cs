using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_BlogSpot
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;

        // class --> villanykorte baloldalon --> Generate Constructor... :

        //public BlogPost(string authorName, string title, string text, string publicationDate)
        //{
        //    AuthorName = authorName;
        //    Title = title;
        //    Text = text;
        //    PublicationDate = publicationDate;
        //}

        public BlogPost(string AuthorName, string Title, string Text, string PublicationDate)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }
    }
}
