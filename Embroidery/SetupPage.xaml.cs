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
    /// Interaction logic for SetupPage.xaml
    /// </summary>
    public partial class SetupPage : Page
    {
        public SetupPage()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            CanvasPage canvasPage = new CanvasPage(HoopSizeSlider.Value);
            this.NavigationService.Navigate(canvasPage);
        }

    
    }
}
