using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            //MainWindow = new Window10();
        }
        //[STAThread]
        //public static void Main()
        //{

        //}
         
        
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //MainWindow window = new WpfApp1.MainWindow();            
            //window.Show();
            //GridEvents gridEvents = new GridEvents();
            //gridEvents.Show();

            //Resources1 resources1 = new Resources1();
            //resources1.Show();

            //ResourceScope resourceScope = new ResourceScope();
            //resourceScope.Show();

            //WPFDataBinding wPFDataBinding = new WPFDataBinding();
            //wPFDataBinding.Show();

            //WPFResources wPFResources = new WPFResources();
            //wPFResources.Show();

            //Templates templates = new Templates();
            //templates.Show();

            //DataTemplate dataTemplate = new DataTemplate();
            //dataTemplate.Show();

            Styles styles = new Styles();
            styles.Show();

            WPFDebuggingDemo wPFDebuggingDemo = new WPFDebuggingDemo();
            wPFDebuggingDemo.Show();

            MainWindow window = new MainWindow();
             
            window.Show();

        }
        //public App()
        //{
        //    App app = new App();

        //    app.StartupUri = new Uri("Window9.xaml", uriKind: UriKind.Relative);
        //}
    }
}
