using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Blog
{
    class Blog
    {
        //list of BlogPosts
        //add BlogPosts to your list
        //delete(int) one item at given index
        //update(int, BlogPost) one item at the given index and update it with another BlogPost

        private List<BlogPost> BloPosts;

        public Blog()
        {
            BloPosts = new List<BlogPost>();
        }

        public void Add(BlogPost post)
        {
            BloPosts.Add(post);
        }

        public void Delete(int num)
        {
            BloPosts.RemoveAt(num);
        }

        public void Update(int num, BlogPost post)
        {
            BloPosts.RemoveAt(num);
            BloPosts.Insert(num, post);
        }

        public void Print()
        {
            foreach (var blog in BloPosts)
            {
                Console.WriteLine("The author is: " + blog.AuthorName + " the title: " + blog.Title +
                    " the text: " + blog.Text + " and the publication date is: " + blog.PublicationDate);
            }
        }
    }
}
