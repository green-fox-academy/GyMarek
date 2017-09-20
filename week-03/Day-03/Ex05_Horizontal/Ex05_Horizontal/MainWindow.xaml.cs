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

namespace Ex05_Horizontal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.
            LineDraw(foxDraw, 20, 50);
            LineDraw(foxDraw, 70, 100);
            LineDraw(foxDraw, 120, 150);
        }
        public void LineDraw(FoxDraw Line, int p1, int p2)
        {
            Line.StrokeColor(Colors.Red);
            Line.DrawLine(new Point(p1, p2), new Point(p1+50, p2));
        }
    }
}
