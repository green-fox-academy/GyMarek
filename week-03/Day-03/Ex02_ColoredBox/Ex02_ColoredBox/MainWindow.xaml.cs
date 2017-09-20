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

namespace Ex02_ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.

            var pointList = new List<Point>()
            {
                new Point(canvas.Width/3, canvas.Height/3),
                new Point(canvas.Width/3*2, canvas.Height/3),
                new Point(canvas.Width/3*2, canvas.Height/3*2),
                new Point(canvas.Width/3, canvas.Height/3*2),
            };
                        
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(pointList[0], pointList[1]);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(pointList[1], pointList[2]);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(pointList[2], pointList[3]);

            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(pointList[3], pointList[0]);
        }
    }
}
