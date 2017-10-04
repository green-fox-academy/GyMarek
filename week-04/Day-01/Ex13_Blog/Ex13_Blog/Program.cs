using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogspot1 = new BlogPost(
                "John Doe",
                "Lorem Ipsum",
                "Lorem ipsum dolor sit amet.",
                "2000.05.04.");
            BlogPost blogspot2 = new BlogPost(
                "Tim Urban",
                "Wait but why",
                "A popular long-form, stick-figure-illustrated blog about almost everything.",
                "2010.10.10.");
            BlogPost blogspot3 = new BlogPost(
                "William Turton",
                "One Engineer Is Trying to Get IBM to Reckon With Trump",
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.",
                "2017.03.28.");

            Blog blogs = new Blog();

            blogs.Add(blogspot1);
            blogs.Add(blogspot2);
            blogs.Add(blogspot3);

            blogs.Delete(2);
            blogs.Update(1, blogspot2);
            blogs.Print();
            Console.ReadLine();
        }
    }
}
