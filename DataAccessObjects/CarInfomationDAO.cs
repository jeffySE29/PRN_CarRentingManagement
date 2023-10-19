using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessObjects
{
    public class CarInfomationDAO 
    {
        private static CarInfomationDAO instance = null;
        private static readonly object instanceLock = new object();
        private CarInfomationDAO() { }

        public static CarInfomationDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarInfomationDAO();
                    }
                    return instance;
                }
            }
        }

        public List<CarInformation> GetCarInformations()
        {//lấy danh sách thông tin xe
            using var db = new FUCarRentingManagementContext();
            return db.CarInformations.Include(f => f.Supplier).Include(f => f.Manufacturer).Include(f => f.RentingDetails).ToList();
        }

        public List<Supplier> GetSuppliersList()
        {//lấy ds suppliers
            using var db = new FUCarRentingManagementContext();
            return db.Suppliers.ToList();
        }

        public List<Manufacturer> GetManufacturersList()
        {//lấy ds manufacturers
            using var db = new FUCarRentingManagementContext();
            return db.Manufacturers.ToList();
        }

        public CarInformation GetCarInformationById(int? id)
        {//lấy car infomation theo id
            var temp = GetCarInformations().SingleOrDefault(m => m.CarId == id);
            return temp;
        }

        public List<CarInformation> GetCarInformationByName(string name)
        {
            var temp = GetCarInformations().FindAll(m => m.CarName.ToLower().Contains(name));
            return temp;
        }

        public List<CarInformation> GetCarInformationByCarRentingPricePerDay(decimal price)
        {
            var temp = GetCarInformations().FindAll(m => m.CarRentingPricePerDay <= price);
            return temp;
        }

        public void CreateCarInfomation(CarInformation carInfo)
        {
            //tạo mới carInfo
            using var db = new FUCarRentingManagementContext();
            db.CarInformations.Add(carInfo);
            db.SaveChanges();
        }

        public void UpdateCarInformation(CarInformation carInfo)
        {
            //update carInfo
            using var db = new FUCarRentingManagementContext();
            db.CarInformations.Update(carInfo);
            db.SaveChanges();
        }

        public void DeleteCarInformation(CarInformation carInfo)
        {
            //update carInfo
            using var db = new FUCarRentingManagementContext();
            db.CarInformations.Remove(carInfo);
            db.SaveChanges();
        }
    }
}
