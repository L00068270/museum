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

namespace museum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new pages.index();
        }

        private void btIndex(object sender, RoutedEventArgs e)
        {
            Main.Content = new pages.index();
        }

        private void btnHistory(object sender, RoutedEventArgs e)
        {
            Main.Content = new pages.history();
        }

        private void btnRecords(object sender, RoutedEventArgs e)
        {
            Main.Content = new pages.records();
        }

        private void btnGallery(object sender, RoutedEventArgs e)
        {
            Main.Content = new pages.gallery();
        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {
            Main.Content = new pages.search();
        }

        //private void btnLogin(object sender, RoutedEventArgs e)
        //{
        //    windows.login login = new windows.login();
        //    login.ShowDialog();
        //}

        //private void btnDashboard(object sender, RoutedEventArgs e)
        //{
        //    windows.dashboard dashboard = new windows.dashboard();
        //    dashboard.ShowDialog();
        //}

        private void btnRegister(object sender, RoutedEventArgs e)
        {
            windows.register register = new windows.register();
            register.ShowDialog();
        }


        private void hyperlink_dashboard_Click(object sender, RoutedEventArgs e)
        {
            windows.login _login = new windows.login();
            _login.ShowDialog();
        }

        private void hyperlink_dashboard2_Click(object sender, RoutedEventArgs e)
        {
            windows.register _register = new windows.register();
            _register.ShowDialog();
        }        
    }
}
