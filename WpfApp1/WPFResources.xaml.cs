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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WPFResources.xaml
    /// </summary>
    public partial class WPFResources : Window
    {
        public WPFResources()
        {
            InitializeComponent();
        }

        private void btnChangeResouce_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush ss = (SolidColorBrush)Resources["brushResource"];

            ss.Color = Color.FromScRgb(251, 235, 327, 4);
            //var ss = Application.Current.Resources["brushResource"];
            //var s =FindResource("brushResource");
        }
    }
}
