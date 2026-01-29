using System;
using VehicleManagementSystem.Data.Enums;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.Services.Interfaces;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Data;

namespace VehicleManagementSystem.Presentor {
    public class addNewVehiclePresenter {
        IAddNewVehicleView _view;
        VehicleServices _vehicleServices;

        public addNewVehiclePresenter(IAddNewVehicleView view, VehicleServices vehicleServices) {
            _view = view;
            _vehicleServices = vehicleServices;
        }

        public void SaveVehicle() {
            if (!IsAllInputsValid(_view)) 
                return;

            Vehicle newVehicle = new Vehicle {
                // Identifiers
                VIN = _view.VehicleIdentificationNumber,
                LicensePlate = _view.VehiclePlateNum,

                // Basic Info
                Manufacturer = _view.VehicleManufacturer,
                Model = _view.VehicleModel,
                YearModel = int.Parse(_view.VehicleYearModel),
                Color = _view.VehicleColor,

                // Classification
                Category = _view.VehicleCatergory,
                FuelType = _view.VehicleFuelType,
                Transmission = _view.VehicleTransmissionType,
                SeatingCapacity = string.IsNullOrWhiteSpace(_view.VehicleSeatCapacity)
                    ? (int?)null
                    : int.Parse(_view.VehicleSeatCapacity),

                // Purchase & Lifecycle
                PurchaseDate = DateTime.Parse(_view.VehiclePurchaseDate),
                PurchasePrice = string.IsNullOrWhiteSpace(_view.VehiclePurchasePrice)
                    ? (decimal?)null
                    : decimal.Parse(_view.VehiclePurchasePrice),

                // Usage & Status
                CurrentOdometerReading = int.Parse(_view.VehicleCurrentOdometer),
                CurrentStatus = "Available", // default business rule
                DailyRate = decimal.Parse(_view.VehicleDailyRate),

                // Media
                ImagePath = _view.VehicleImagePath,

                // System fields
                IsActive = true,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            };
            
            try {
                _vehicleServices.AddVehicle(newVehicle);
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
            
        }

        private bool IsAllInputsValid(IAddNewVehicleView inputs) {
            bool hadNoError = true;

            if (!IsNumericInputsValid(inputs))
                hadNoError = false;

            if (!IsAllInputsFilledUp(inputs))
                hadNoError = false;

            return hadNoError;
        }

        private bool IsNumericInputsValid(IAddNewVehicleView inputs) {
            bool hadNoError = true;

            if (!Double.TryParse(inputs.VehicleDailyRate, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleDailyRate, "Invalid Input");
                hadNoError = false;
            }

            if (!Double.TryParse(inputs.VehiclePurchasePrice, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePurchasePrice, "Invalid Input");
                hadNoError = false;
            }

            if (!Double.TryParse(inputs.VehicleCurrentOdometer, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleCurrentOdometer, "Invalid Input");
                hadNoError = false;
            }

            if (!Double.TryParse(inputs.VehicleDailyRate, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleDailyRate, "Invalid Input");
                hadNoError = false;
            }

            if (!int.TryParse(inputs.VehicleSeatCapacity, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleSeatCapacity, "Invalid Input");
                hadNoError = false;
            }

            if (!int.TryParse(inputs.VehicleYearModel, out _)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleYearModel, "Invalid Input");
                hadNoError = false;
            }

            return hadNoError;
        }

        private bool IsAllInputsFilledUp(IAddNewVehicleView inputs) {
            bool hadNoError = true;

            if (string.IsNullOrWhiteSpace(inputs.VehicleIdentificationNumber)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehiclePlateNum)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePlateNum, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleColor)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleColor, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleManufacturer)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleManufacturer, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleModel)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleModel, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleYearModel)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleYearModel, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehiclePurchasePrice)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePurchasePrice, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleCurrentOdometer)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleCurrentOdometer, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleSeatCapacity)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleSeatCapacity, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.VehicleDailyRate)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleDailyRate, "Required.");
                hadNoError = false;
            }

            return hadNoError;
        }

    } 
}
