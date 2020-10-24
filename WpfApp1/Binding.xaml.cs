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
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get
            {
                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }
        UserViewModel userViewModel = new UserViewModel();
        public Binding()
        {
            InitializeComponent();
            this.DataContext = userViewModel;
            ButtonCommand = new RelayCommand(new Action<object>(ShowMessage));
        }

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}
