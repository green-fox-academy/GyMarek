using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Post_It
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;

            public PostIt(string BackgroundColor, string Text, string TextColor) //this is contructor
            {
                this.BackgroundColor = BackgroundColor;
                this.Text = Text;
                this.TextColor = TextColor;
            }
        }

        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt("Orange", "Idea 1", "Blue");
            PostIt postIt2 = new PostIt("Pink", "Awesome", "Black");
            PostIt postIt3 = new PostIt("Yellow", "Superb", "Green");

            //PostIt postIt1;
            //PostIt postIt2;
            //PostIt postIt3;

            //postIt1.BackgroundColor = "Orange";
            //postIt1.Text = "Idea 1";
            //postIt1.TextColor = "Blue";

            //postIt2.BackgroundColor = "Pink";
            //postIt2.Text = "Awesome";
            //postIt2.TextColor = "Black";

            //postIt3.BackgroundColor = "Yellow";
            //postIt3.Text = "Superb";
            //postIt3.TextColor = "Green";
        }
    }
}
