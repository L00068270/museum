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
using museum.viewmodels;
using museum.views;
using museum.windows;
using System.Windows.Navigation;

namespace museum.windows
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Window
    {
        /************************************************************************************************** 
        * (1)
        * database framework reference. link to LinqHqSqlDatabaseClasses
        **************************************************************************************************/
        LinqHqSqlDatabaseClassesDataContext dc = new LinqHqSqlDatabaseClassesDataContext
            (Properties.Settings.Default.BookofHonourConnectionString);




        /**************************************************************************************************
        * (2)
        * new instance of library member. 'LOGIN' refers to this
        **************************************************************************************************/
        public LibraryMember _instanceLibraryMember = new LibraryMember();




        /**************************************************************************************************
       * (3)
       * new instance of library member. 'LOGIN' refers to this
       **************************************************************************************************/
        public LibraryMember currentLibraryMember;





        /**************************************************************************************************
        * (4)
        * set the dashboard to load the user details (First Name)
        **************************************************************************************************/
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblCurrentUser.Content = _instanceLibraryMember.NameFirst;
        }




        /**************************************************************************************************
        * (5)
        * default screen will be view_records
        **************************************************************************************************/
        public dashboard()
        {
            InitializeComponent();
            DataContext = new views.view_records();
        }

 
        

        /**************************************************************************************************
        * (6)
        * hyperlynks here
        **************************************************************************************************/

        private void hyperlink_LibraryMember_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodels.viewmodel_librarymember();
        }

        private void hyperlink_BookofHonour_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new viewmodels.viewmodel_records();
        }
    }
}
