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

namespace Ex03_Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.

            var pointList = new List<Point>()
            {
                new Point(canvas.Width/3, canvas.Height/3),
                new Point(canvas.Width/3*2, canvas.Height/3),
                new Point(canvas.Width/3*2, canvas.Height/3*2),
                new Point(canvas.Width/3, canvas.Height/3*2),
            };

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(pointList[0], pointList[2]);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(pointList[1], pointList[3]);            
        }
    }
}
