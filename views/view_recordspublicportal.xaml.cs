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

namespace museum.views
{
    /// <summary>
    /// Interaction logic for view_recordspublicportal.xaml
    /// </summary>
    public partial class view_recordspublicportal : UserControl
    {
        /**************************************************************************************************
        * database framework reference
        *************************************************************************************************/

        LinqHqSqlDatabaseClassesDataContext dc = new LinqHqSqlDatabaseClassesDataContext
            (Properties.Settings.Default.BookofHonourConnectionString);


        public static DataGrid datagrid;

        public view_recordspublicportal()
        {
            InitializeComponent();
            functionToLoadDatabaseToDataGrid();
        }

        //*************************************************************************************************        
        // function here
        //*************************************************************************************************
        public void functionToLoadDatabaseToDataGrid()
        {
            myDataGrid.ItemsSource = dc.BookofHonours.ToList();
            datagrid = myDataGrid;
        }
    }
}
