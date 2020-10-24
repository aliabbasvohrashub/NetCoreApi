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
    /// Interaction logic for WPFDebuggingDemo.xaml
    /// </summary>
    public partial class WPFDebuggingDemo : Window
    {
        public WPFDebuggingDemo()
        {
            InitializeComponent();
            DataContext = Employee.GetEmployee();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public static Employee GetEmployee()
        {

            var emp = new Employee()
            {
                Name = "Ali Ahmed",
                Title = "Developer"
            };

            return emp;
        }
    }
}
