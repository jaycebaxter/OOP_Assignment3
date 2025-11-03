using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Setting the cost before any services are selected
        public const decimal initialTotalCost = 0;

        // List of service objects 
        private List<Service> listOfServices = new List<Service>();



        /// <summary>
        /// Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string phoneNumber = TxtPhoneNumber.Text;

            string vehicleMake = "";
            if (CmbVehicleMake.SelectedItem != null)
            {
                vehicleMake = (CmbVehicleMake.SelectedItem as ComboBoxItem).Content.ToString();
            }

            string vehicleModel = TxtVehicleModel.Text;
            string vehicleColour = TxtVehicleColour.Text;

            string vehicleYearStr = "";
            if (CmbVehicleYear.SelectedItem != null)
            {
                vehicleYearStr = (CmbVehicleYear.SelectedItem as ComboBoxItem).Content.ToString();
            }

            bool engineOil = ChkEngineOilChange.IsChecked == true;
            bool transOil = ChkTransmissionOilChange.IsChecked == true;
            bool airFilter = ChkAirFilterChange.IsChecked == true;

            if (firstName == "" || lastName == "" || phoneNumber == "" || vehicleMake == "" || vehicleModel == "" || vehicleColour == "" || vehicleYearStr == "")
            {
                MessageBox.Show("Null fields not accepted");
                return;
            }

            if (engineOil == false && transOil == false && airFilter == false)
            {
                MessageBox.Show("Select at least one service");
            }

            int tempYear = int.Parse(vehicleYearStr);
            decimal totalCost = 0;

            if (engineOil == true)
            {
                totalCost = totalCost + 60;
            }

            if (transOil == true)
            {
                totalCost = totalCost + 120;
            }

            if (airFilter == true)
            {
                totalCost = totalCost + (decimal)40.5;
            }

            Service newService = new Service(firstName, lastName, phoneNumber, vehicleMake, vehicleModel, tempYear, vehicleColour, engineOil, transOil, airFilter, totalCost);

            listOfServices.Add(newService);

            CustomerListView.Items.Add(new
            {
                pCustomerID = newService.GetCustomerID(),
                pFirstName = newService.GetFirstName(),
                pLastName = newService.GetLastName(),
                pPhoneNumber = newService.GetPhoneNumber(),
                pVehicleMake = newService.GetVehicleMake(),
                pVehicleModel = newService.GetVehicleModel(),
                pVehicleYear = newService.GetVehicleYear(),
                pVehicleColour = newService.GetVehicleColour(),
                pEngOilChange = newService.GetEngOilChange(),
                pTransOilChange = newService.GetTransOilChange(),
                pAirFilterChange = newService.GetAirFilterChange(),
                pTotalCost = newService.GetTotalCost()
            });
        }

        /// <summary>
        /// New button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Remove button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Remove all button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveAll_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}