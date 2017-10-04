using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Blog
{
    class BlogPost
    {
        public BlogPost()
        {
        }

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            AuthorName = authorName;
            Title = title;
            Text = text;
            PublicationDate = publicationDate;
        }

        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublicationDate { get; set; }
    }
}
