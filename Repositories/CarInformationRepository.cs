using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;

namespace Repositories
{
    public class CarInformationRepository: ICarInformationRepository
    {
        public List<CarInformation> GetCarInformations()
            => CarInfomationDAO.Instance.GetCarInformations();
        public List<Supplier> GetSuppliersList() 
            => CarInfomationDAO.Instance.GetSuppliersList();

        public List<Manufacturer> GetManufacturersList() 
            => CarInfomationDAO.Instance.GetManufacturersList();

        public CarInformation GetCarInformationById(int? id)
            => CarInfomationDAO.Instance.GetCarInformationById(id);

        public List<CarInformation> GetCarInformationByName(string name)
            => CarInfomationDAO.Instance.GetCarInformationByName(name);
        public List<CarInformation> GetCarInformationByCarRentingPricePerDay(decimal price)
            => CarInfomationDAO.Instance.GetCarInformationByCarRentingPricePerDay((decimal)price);

        public void CreateCarInfomation(CarInformation carInfo)
            => CarInfomationDAO.Instance.CreateCarInfomation(carInfo);

        public void UpdateCarInformation(CarInformation carInfo)
            => CarInfomationDAO.Instance.UpdateCarInformation(carInfo);

        public void DeleteCarInformation(CarInformation carInfo)
            => CarInfomationDAO.Instance.DeleteCarInformation(carInfo);
    }
}
