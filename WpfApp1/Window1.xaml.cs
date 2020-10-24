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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void AboutDialog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " + e.OriginalSource.GetType().Name + " @ " + e.Timestamp;
            // In this example, all possible sources derive from Control
            Control source = e.Source as Control;
            // Toggle the border on the source control
            if (source.BorderThickness != new Thickness(5))
            {
                source.BorderThickness = new Thickness(5);
                source.BorderBrush = Brushes.Black;
            }
            else
                source.BorderThickness = new Thickness(0);
        }

        private void Window_Selected(object sender, RoutedEventArgs e)
        {
            var s = e;
            //if (e.Count > 0)
                //MessageBox.Show("You just selected " +e.AddedItems[0]);
        }
    }
}
