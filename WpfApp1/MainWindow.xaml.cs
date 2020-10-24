using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using WpfApp1.ViewModel;

namespace WpfApp1
{

    public class MyConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Math.Round((double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Contacts> ContactsList;
        public MainWindow()
        {
            //NavigationWindow navigationWindow = new NavigationWindow();
            //navigationWindow.Activated;
            InitializeComponent();

            //BindingContext = this;
            //ContactsList = new ObservableCollection<Contacts>();

            //for (int i = 1; i < 3; i++)
            //{
            //    ContactsList.Add(new Contacts() { Id = i, Name = $"student{i}", Address = $"address {i}" });
            //}

            //ContactsListView.ItemsSource = ContactsList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Background = Brushes.Blue;
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Background = Brushes.Yellow;
            }
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            //StudentViewModel studentViewModel = new StudentViewModel();
            //studentViewModel.Loaded();
            //StudentViewControl.DataContext = studentViewModel;
        }
    }
}
