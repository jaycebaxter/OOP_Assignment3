using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Service
    {
        #region variables
        private int count;
        private int customerID;
        private string? firstName;
        private string? lastName;
        private string? phoneNumber;
        private string vehicleMake;
        private string vehicleModel;
        private string vehicleColour;
        private int vehicleYear;
        private bool engOilChange;
        private bool transOilChange;
        private bool airFilterChange;
        private decimal totalCost; 
        #endregion

        #region defConst

        // Default constructor
        public Service()
        {
            count = count + 1;

            customerID = count;
            firstName = "";
            lastName = "";
            phoneNumber = "";
            vehicleMake = "";
            vehicleModel = "";
            vehicleColour = "";
            vehicleYear = 0;
            engOilChange = false;
            transOilChange = false;
            airFilterChange = false;
            totalCost = 0;
        } 
        #endregion

        #region paraConst

        // Parameterized constructor
        // I'm using P to denote that it's a parameter instead of a variable name... so I don't get confused
        // Rename later?
        public Service(string pFirstName, string pLastName, string pPhoneNumber, string pVehicleMake, string pVehicleModel, string pVehicleColour, int pVehicleYear, bool pEngOilChange, bool pTransOilChange, bool pAirFilterChange, decimal pTotalCost)
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
        #endregion

        #region getters

        // GETTERS

        /// <summary>
        /// Getter for customerID
        /// </summary>
        /// <returns> customerID </returns>
        public int GetCustomerID()
        {
            return customerID;
        }

        /// <summary>
        /// Getter for firstName
        /// </summary>
        /// <returns> firstName </returns>
        public string GetFirstName()
        {
            return firstName;
        }

        /// <summary>
        /// Getter for lastName
        /// </summary>
        /// <returns> lastName </returns>
        public string GetLastName()
        {
            return lastName;
        }

        /// <summary>
        /// Getter for phoneNumber
        /// </summary>
        /// <returns> phoneNumber </returns>
        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        /// <summary>
        /// Getter for vehicleMake
        /// </summary>
        /// <returns> vehicleMake </returns>
        public string GetVehicleMake()
        {
            return vehicleMake;
        }

        /// <summary>
        /// Getter for vehicleModel
        /// </summary>
        /// <returns> vehicleModel </returns>
        public string GetVehicleModel()
        {
            return vehicleModel;
        }

        /// <summary>
        /// Getter for vehicleYear
        /// </summary>
        /// <returns> vehicleYear </returns>
        public int GetVehicleYear()
        {
            return vehicleYear;
        }

        /// <summary>
        /// Getter for engOilChange
        /// </summary>
        /// <returns> engOilChange </returns>
        public bool GetEngOilChange()
        {
            return engOilChange;
        }

        /// <summary>
        /// Getter for transOilChange
        /// </summary>
        /// <returns> transOilChange </returns>
        public bool GetTransOilChange()
        {
            return transOilChange;
        }

        /// <summary>
        /// Getter for airFilterChange
        /// </summary>
        /// <returns> airFilterChange </returns>
        public bool GetAirFilterChange()
        {
            return airFilterChange;
        }

        /// <summary>
        /// Getter for totalCost
        /// </summary>
        /// <returns> totalCost </returns>
        public decimal GetTotalCost()
        {
            return totalCost;
        }

        #endregion

        #region setters

        // SETTERS

        /// <summary>
        /// Setter for firstName
        /// </summary>
        /// <param name="pFirstName"></param>
        public void SetFirstName(string pFirstName)
        {
            firstName = pFirstName;
        }

        /// <summary>
        /// Setter for lastName
        /// </summary>
        /// <param name="pLastName"></param>
        public void SetLastName(string pLastName)
        {
            lastName = pLastName;
        }

        /// <summary>
        /// Setter for phoneNumber
        /// </summary>
        /// <param name="pPhoneNumber"></param>
        public void SetPhoneNumber(string pPhoneNumber)
        {
            phoneNumber = pPhoneNumber;
        }

        /// <summary>
        /// Setter for vehicleMake
        /// </summary>
        /// <param name="pVehicleMake"></param>
        public void SetVehicleMake(string pVehicleMake)
        {
            vehicleMake = pVehicleMake;
        }

        /// <summary>
        /// Setter for vehicleModel
        /// </summary>
        /// <param name="pVehicleModel"></param>
        public void SetVehicleModel(string pVehicleModel)
        {
            vehicleModel = pVehicleModel;
        }

        /// <summary>
        /// Setter for vehicleColour
        /// </summary>
        /// <param name="pVehicleColour"></param>
        public void SetVehicleColour(string pVehicleColour)
        {
            vehicleColour = pVehicleColour;
        }

        /// <summary>
        /// Setter for vehicleYear
        /// </summary>
        /// <param name="pVehicleYear"></param>
        public void SetVehicleYear(int pVehicleYear)
        {
            vehicleYear = pVehicleYear;
        }


        /// <summary>
        /// Setter for engOilChange
        /// </summary>
        /// <param name="pEngOilChange"></param>
        public void SetEngOilChange(bool pEngOilChange)
        {
            engOilChange = pEngOilChange;
        }

        /// <summary>
        /// Setter for transOilChange
        /// </summary>
        /// <param name="pTransOilChange"></param>
        public void SetTransOilChange(bool pTransOilChange)
        {
            transOilChange = pTransOilChange;
        }

        /// <summary>
        /// Setter for airFilterChange
        /// </summary>
        /// <param name="pAirFilterChange"></param>
        public void SetAirFilterChange(bool pAirFilterChange)
        {
            airFilterChange = pAirFilterChange;
        }

        /// <summary>
        /// Setter for totalCost
        /// </summary>
        /// <param name="pTotalCost"></param>
        public void SetTotalCost(decimal pTotalCost)
        {
            totalCost = pTotalCost;
        }
        #endregion

        #region totalCost

        /// <summary>
        /// Calculates the total cost depending on services chosen
        /// </summary>
        /// <returns> totalCost </returns>
        public decimal CalculateTotalCost()
        {
            decimal tempCost = 0;

            if (engOilChange == true)
            {
                tempCost = tempCost + (decimal)60;
            }

            if (transOilChange == true)
            {
                tempCost = tempCost + (decimal)120;
            }

            if (airFilterChange == true)
            {
                tempCost = tempCost + (decimal)40.5;
            }

            totalCost = tempCost;
            return totalCost;
        } 
        #endregion
    }
}
