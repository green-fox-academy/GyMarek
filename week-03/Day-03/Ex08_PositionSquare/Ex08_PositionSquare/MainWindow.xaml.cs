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

namespace Ex08_PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.   

            RectangleDraw(foxDraw, 50, 50);
            RectangleDraw(foxDraw, 100, 100);
            RectangleDraw(foxDraw, 150, 150);
        }
        public void RectangleDraw(FoxDraw Line, int p1, int p2)
        {
            Line.DrawRectangle(p1, p2, 50, 50);
        }
    }
}
