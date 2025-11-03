using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Service
    {
        private int count;
        private int customerID;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string vehicleMake;
        private string vehicleModel;
        private string vehicleColour;
        private int vehicleYear;
        private bool engOilChange;
        private bool transOilChange;
        private bool airFilterChange;
        private decimal totalCost;

        // Default constructor
        public Service()
        {
            count = count + 1;

            customerID = count;
        }

        // Parameterized constructor
        // I'm using P to denote that it's a parameter instead of a variable name... so I don't get confused
        // Rename later?
        public Service (string pFirstName, string pLastName, string pPhoneNumber, string pVehicleMake, string pVehicleModel, string pVehicleColour, int pVehicleYear, bool pEngOilChange, bool pTransOilChange, bool pAirFilterChange, decimal pTotalCost)
        {
            firstName = pFirstName;
            lastName = pLastName;
            phoneNumber = pPhoneNumber;
            vehicleMake = pVehicleMake;
            vehicleModel = pVehicleModel;
            vehicleColour = pVehicleColour;
            vehicleYear = pVehicleYear;
            engOilChange = pEngOilChange;
            transOilChange = pTransOilChange;
            airFilterChange = pAirFilterChange;
            totalCost = pTotalCost;
        }
    }
}
