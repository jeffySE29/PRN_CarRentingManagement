using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICarInformationRepository
    {
        List<CarInformation> GetCarInformations();
        List<Supplier> GetSuppliersList();
        List<Manufacturer> GetManufacturersList();

        CarInformation GetCarInformationById(int? id);

        List<CarInformation> GetCarInformationByName(string name);
        List<CarInformation> GetCarInformationByCarRentingPricePerDay(decimal price);

        void CreateCarInfomation(CarInformation carInfo);

        void UpdateCarInformation(CarInformation carInfo);

        void DeleteCarInformation(CarInformation carInfo);

    }
}
