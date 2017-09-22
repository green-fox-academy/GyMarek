using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Fractral_Tree
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double size = canvas.Width;

            var linePointList = new List<Point>()
            {
                new Point(size*0.5, size*0.8),
                new Point(size*0.5, size*0.7),           
            };

            Random r = new Random();
         
            foxDraw.StrokeColor(Color.FromRgb((byte)r.Next(255),
                (byte)r.Next(255), (byte)r.Next(255)));

            Drawing(foxDraw, linePointList[0], linePointList[1], size, 4);
        }

        public static void Drawing(FoxDraw foxDraw, Point p1, Point p2, double size, int depth)
        {
            var p3 = new Point(p2.X-50, p2.Y-50);
            var p4 = new Point(p2.X+50, p2.Y-50);
            var p5 = new Point(p2.X, p2.Y-50);

            if (depth == 0)
            {
                return;
            }
            foxDraw.DrawLine(p1 , p2);
 
            Drawing(foxDraw, p2, p3, size/10, depth - 1);
            Drawing(foxDraw, p2, p4, size/10, depth - 1);
            Drawing(foxDraw, p2, p5, size/10, depth - 1);
        }
    }
}
