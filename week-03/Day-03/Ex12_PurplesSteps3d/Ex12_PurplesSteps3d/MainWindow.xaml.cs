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

namespace Ex12_PurplesSteps3d
{   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // r4.png

            int position = 10;
            int increase = 2;
            int noOfBoxes = 100;
            
            for (int size = 0; size <= noOfBoxes* increase; size+= increase)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(position, position, size, size);
                position += size;
            }
        }
    }
}
