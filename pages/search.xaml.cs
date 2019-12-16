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

namespace museum.pages
{
    /// <summary>
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        /************************************************************************************************** 
        * (1)
        * database framework reference. link to LinqHqSqlDatabaseClasses
        **************************************************************************************************/
        LinqHqSqlDatabaseClassesDataContext dc = new LinqHqSqlDatabaseClassesDataContext
            (Properties.Settings.Default.BookofHonourConnectionString);


        /**************************************************************************************************
        * (5)
        * default screen will be view_records
        **************************************************************************************************/
        public search()
        {
            InitializeComponent();
            DataContext = new views.view_recordspublicportal();
        }
    }
}
