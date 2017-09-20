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

namespace Ex10_RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.
            Random r = new Random();

            for (int size = 600; size >= 0; size -= 3)
            {
                RectangleDraw(foxDraw, size, (Color.FromArgb(
                    (byte)r.Next(256),
                    (byte)r.Next(256),
                    (byte)r.Next(256),
                    (byte)r.Next(256))));
            }
        }
        public void RectangleDraw(FoxDraw foxDraw, int size, Color colors)
        {
            foxDraw.FillColor(colors);
            foxDraw.DrawRectangle(canvas.Width / 2 - size / 2, canvas.Height / 2 - size / 2, size, size);
        }
    }
}
