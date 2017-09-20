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

namespace Ex13_CheckerBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // fill the canvas with a checkerboard pattern.
     
            int size = 50;
            int pcs = 600 / size;
            Color firstColor = Colors.Red;
            Color secondColor = Colors.DarkBlue;

            for (int i = 0; i < pcs; i++)
            {
                for (int j = 0; j < pcs; j++)
                {                
                if ((i+j) % 2 == 0)
                {
                    foxDraw.FillColor(firstColor);
                }
                else
                {
                    foxDraw.FillColor(secondColor);
                }
                foxDraw.DrawRectangle(size*i, size*j, size, size);
                }       
            }
        }
    }
}
