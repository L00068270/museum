using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
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
    /// Interaction logic for view_records.xaml
    /// </summary>
    public partial class view_records : UserControl
    {
        /**************************************************************************************************
        * database framework reference
        *************************************************************************************************/

        LinqHqSqlDatabaseClassesDataContext dc = new LinqHqSqlDatabaseClassesDataContext
            (Properties.Settings.Default.BookofHonourConnectionString);


        public static DataGrid datagrid;

        public view_records()
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


        //*************************************************************************************************        
        // buttons here
        //*************************************************************************************************
        private void btnInsert_Click_1(object sender, RoutedEventArgs e)
        {
            BookofHonour newBookofHonourObject = new BookofHonour()
            {
                Surname = tbxSurname.Text,
                First_Name = tbxName.Text,
                Rank = tbxRank.Text,
                Service___Regiment_No_ = int.Parse(this.tbxServiceRegimentNo.Text),
                Regiment___Unit___Service = tbxRegimentUnitService.Text,
                Attestation_Date___Place = tbxAttestationDatePlace.Text,
                Residence_When_Enlisted = tbxResidenceWhenEnlisted.Text,
                Date_of_Birth = tbxDateofBirth.Text,
                Place_of_Birth = tbxPlaceofBirth.Text,
                Fathers_Name = tbxFathersName.Text,
                Mothers_Name = tbxMothersName.Text,
                Parental___Next_of_Kin_Address = tbxParentalNextofKinAddresss.Text,
                Next_of_Kin = tbxNextofKin.Text,
                Religion = tbxReligion.Text,
                Marital_Status = tbxMaritalStatus.Text,
                Spouse_Name = tbxSpouseName.Text,
                Spouse_Address = tbxSpouseAddress.Text,
                Cause_of_Death = tbxCauseofDeath.Text,
                Place_of_Death = tbxPlaceofDeath.Text,
                //Date_of_Death = DataSetDateTime.parse(this.tbxDateofDeath.Text),
                Place_of_Burial = tbxPlaceofBurial.Text,
                Age_at_Death = int.Parse(this.tbxAgeatDeath.Text),
                Memorial = tbxMemorials.Text,
                Will = tbxWill.Text,
                Award___Honours___Medals = tbxAwardHonoursMedals.Text,
                Image_s_ = tbxImages.Text,
                Any_additional_info = tbxAnyAdditionalInfo.Text,
            };
            dc.BookofHonours.InsertOnSubmit(newBookofHonourObject);
            dc.SubmitChanges();
            view_records.datagrid.ItemsSource = dc.BookofHonours.ToList();

            //now clear textboxes after insert
            tbxSurname.Text = "";
            tbxName.Text = "";
            tbxRank.Text = "";
            tbxServiceRegimentNo.Text = "";
            tbxRegimentUnitService.Text = "";
            tbxResidenceWhenEnlisted.Text = "";
            tbxDateofBirth.Text = "";
            tbxPlaceofBirth.Text = "";
            tbxFathersName.Text = "";
            tbxMothersName.Text = "";
            tbxParentalNextofKinAddresss.Text = "";
            tbxNextofKin.Text = "";
            tbxReligion.Text = "";
            tbxMaritalStatus.Text = "";
            tbxSpouseName.Text = "";
            tbxSpouseAddress.Text = "";
            tbxCauseofDeath.Text = "";
            tbxPlaceofDeath.Text = "";
            tbxDateofDeath.Text = "";
            tbxPlaceofBurial.Text = "";
            tbxAgeatDeath.Text = "";
            tbxMemorials.Text = "";
            tbxWill.Text = "";
            tbxAwardHonoursMedals.Text = "";
            tbxImages.Text = "";
            tbxAnyAdditionalInfo.Text = "";

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            dc.SubmitChanges();

            //now clear textboxes after insert
            tbxSurname.Text = "";
            tbxName.Text = "";
            tbxRank.Text = "";
            tbxServiceRegimentNo.Text = "";
            tbxRegimentUnitService.Text = "";
            tbxResidenceWhenEnlisted.Text = "";
            tbxDateofBirth.Text = "";
            tbxPlaceofBirth.Text = "";
            tbxFathersName.Text = "";
            tbxMothersName.Text = "";
            tbxParentalNextofKinAddresss.Text = "";
            tbxNextofKin.Text = "";
            tbxReligion.Text = "";
            tbxMaritalStatus.Text = "";
            tbxSpouseName.Text = "";
            tbxSpouseAddress.Text = "";
            tbxCauseofDeath.Text = "";
            tbxPlaceofDeath.Text = "";
            tbxDateofDeath.Text = "";
            tbxPlaceofBurial.Text = "";
            tbxAgeatDeath.Text = "";
            tbxMemorials.Text = "";
            tbxWill.Text = "";
            tbxAwardHonoursMedals.Text = "";
            tbxImages.Text = "";
            tbxAnyAdditionalInfo.Text = "";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            dc.SubmitChanges();

            //now clear textboxes after insert
            tbxSurname.Text = "";
            tbxName.Text = "";
            tbxRank.Text = "";
            tbxServiceRegimentNo.Text = "";
            tbxRegimentUnitService.Text = "";
            tbxResidenceWhenEnlisted.Text = "";
            tbxDateofBirth.Text = "";
            tbxPlaceofBirth.Text = "";
            tbxFathersName.Text = "";
            tbxMothersName.Text = "";
            tbxParentalNextofKinAddresss.Text = "";
            tbxNextofKin.Text = "";
            tbxReligion.Text = "";
            tbxMaritalStatus.Text = "";
            tbxSpouseName.Text = "";
            tbxSpouseAddress.Text = "";
            tbxCauseofDeath.Text = "";
            tbxPlaceofDeath.Text = "";
            tbxDateofDeath.Text = "";
            tbxPlaceofBurial.Text = "";
            tbxAgeatDeath.Text = "";
            tbxMemorials.Text = "";
            tbxWill.Text = "";
            tbxAwardHonoursMedals.Text = "";
            tbxImages.Text = "";
            tbxAnyAdditionalInfo.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItem as BookofHonour).Ref_No;
            var deleteBook = dc.BookofHonours.Where(BookofHonour => BookofHonour.Ref_No == id).Single();
            dc.BookofHonours.DeleteOnSubmit(deleteBook);
            dc.SubmitChanges();
            myDataGrid.ItemsSource = dc.BookofHonours.ToList();
        }
    }
}
