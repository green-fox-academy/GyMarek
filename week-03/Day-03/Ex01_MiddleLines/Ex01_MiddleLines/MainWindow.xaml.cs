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

namespace Ex01_MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.

            var startPointHor = new Point(0, canvas.Height/2);
            var endPointHor = new Point(canvas.Width, canvas.Height/2);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startPointHor,endPointHor);

            var startPointVer = new Point(canvas.Width / 2, 0);
            var endPointVer = new Point(canvas.Width/2, canvas.Height);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startPointVer,endPointVer);            
        }
    }
}
