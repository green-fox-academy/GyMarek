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

namespace Ex11_DrawingSquares
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double size = canvas.Width;
                        
            foxDraw.BackgroundColor(Colors.Yellow);
            foxDraw.StrokeColor(Colors.Black);
            Drawing(foxDraw, 0,0,size, 4);
        }

        public static void Drawing(FoxDraw foxDraw, double x, double y, double size, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            foxDraw.DrawLine(x + size / 3, y, x + size / 3, y + size);
            foxDraw.DrawLine(x + size / 3 * 2, y, x + size / 3 * 2, y + size);
            foxDraw.DrawLine(x, y + size / 3, x + size, y + size / 3);
            foxDraw.DrawLine(x, y + size / 3 * 2, x + size, y + size / 3 * 2);

            Drawing(foxDraw, x + size / 3, y, size / 3, depth - 1);
            Drawing(foxDraw, x + size / 3, y + size / 3 * 2, size / 3, depth - 1);
            Drawing(foxDraw, x, y + size / 3, size / 3, depth - 1);
            Drawing(foxDraw, x + size / 3 * 2, y + size / 3, size / 3, depth - 1);
        
        }
    }
}
