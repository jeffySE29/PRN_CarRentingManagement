using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static object lockObject = new object();

        private CustomerDAO() { }

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }

        public Customer CheckLogin(string email, string password)
        {

            using var db = new FUCarRentingManagementContext();
            return db.Customers.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        }

        public List<Customer> GetCustomersList() 
        {
            using var db = new FUCarRentingManagementContext();
            return db.Customers.ToList();
        }

        public int GetCustomerMaxId()
        {
            using var db = new FUCarRentingManagementContext();

            // Sắp xếp danh sách Customer theo ID giảm dần và lấy ID của phần tử đầu tiên (ID lớn nhất)
            int maxId = db.Customers.OrderByDescending(rt => rt.CustomerId).Select(rt => rt.CustomerId).FirstOrDefault();
            return maxId;
        }
        public Customer GetCustomerById(int? id)
        {//lấy customer theo id
            var temp = GetCustomersList().
                SingleOrDefault(m => m.CustomerId == id);
            return temp;
        }

        public int GetIdOfCustomerByEmail(string email)
        {
            var temp = GetCustomersList().SingleOrDefault(m => m.Email.Equals(email));
            return temp.CustomerId;
        }
        public void CreateCustomer(Customer cusInfo)
        {
            //tạo mới cusInfo
            using var db = new FUCarRentingManagementContext();
            db.Customers.Add(cusInfo);
            db.SaveChanges();
        }

        public void UpdateCustomer(Customer cusInfo)
        {
            //update cusInfo
            using var db = new FUCarRentingManagementContext();
            db.Customers.Update(cusInfo);
            db.SaveChanges();
        }

        public void DeleteCustomer(Customer cusInfo)
        {
            //delete Cus
            using var db = new FUCarRentingManagementContext();
            db.Customers.Remove(cusInfo);
            db.SaveChanges();
        }
    }
}
