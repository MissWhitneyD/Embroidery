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

namespace Embroidery
{
    /// <summary>
    /// Interaction logic for CanvasPage.xaml
    /// </summary>
    public partial class CanvasPage : Page
    {
        Line newLine;
        PointCollection myPointCollection = new PointCollection();
        public CanvasPage(double HoopSize)
        {
            InitializeComponent();
            CreateHoop(HoopSize);

        }

        private void CreateHoop(double hoopSize)
        {           
            Ellipse myHoop = new Ellipse();
            myHoop.Stroke = System.Windows.Media.Brushes.Black;
            myHoop.Width = hoopSize * 100;
            myHoop.Height = hoopSize * 100;
            Canvas.SetLeft(myHoop, 100);
            Canvas.SetTop(myHoop, 100);
            myCanvas.Width = (200 + (hoopSize * 100));
            myCanvas.Height = (200 + (hoopSize * 100));
            myCanvas.Children.Add(myHoop);
        }

        private void Line_Type_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Start_Point(object sender, MouseButtonEventArgs e)
        {
            if (myCanvas.CaptureMouse())
            {
                Point position = Mouse.GetPosition(myCanvas);
                newLine = new Line();
                newLine.X1 = position.X;
                newLine.X2 = position.X;
                newLine.Y1 = position.Y;
                newLine.Y2 = position.Y;
                newLine.StrokeThickness = 2;
                newLine.Stroke = System.Windows.Media.Brushes.Black;
                
                myCanvas.Children.Add(newLine);

            }

        }

        private void End_Point(object sender, MouseButtonEventArgs e)
        {
            ((Canvas)sender).ReleaseMouseCapture();
        }



        private void Move_Line(object sender, MouseEventArgs e)
        {
            if(myCanvas.IsMouseCaptured && e.LeftButton == MouseButtonState.Pressed)
            {
                var line = myCanvas.Children.OfType<Line>().LastOrDefault();
                if(line != null)
                {
                    var endPoint = e.GetPosition(myCanvas);
                    line.X2 = endPoint.X;
                    line.Y2 = endPoint.Y;
                }
            }
        }

      
    }

}
